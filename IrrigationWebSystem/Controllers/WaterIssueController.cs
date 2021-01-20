﻿using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using IrrigationWebSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Controllers
{
    public class WaterIssueController : Controller
    {
        private IWaterIssueRepository _waterIssueRepository;
        private IWaterLevelCapacityMuruthawelaTank _waterLevelCapacityRepository;

        public WaterIssueController(IWaterIssueRepository waterIssueRepository,
                                    IWaterLevelCapacityMuruthawelaTank waterLevelCapacityRepository)
        {
            _waterIssueRepository = waterIssueRepository;
            _waterLevelCapacityRepository = waterLevelCapacityRepository;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            //CultureInfo culture = new CultureInfo("en-US");
            //var wmDailyWaterLevelAndissueVM = new WmDailyWaterLevelAndissueVM()
            //{                
            //    WaterIssuedDurationFromDateWithTime = DateTime.Today,
            //    WaterIssuedDurationToDateWithTime=DateTime.Now
            //};

            return View();
        }


        [HttpPost]
        public ActionResult Create(WmDailyWaterLevelAndissueVM wmDailyWaterLevelAndissueVM)
        {
            string tankName = "Muruthawela";
            
            //get capacity by level
            int tankCapacity = _waterLevelCapacityRepository
                                .GetMuruthawelaWaterCapacityByLevel(wmDailyWaterLevelAndissueVM.WarterLevelAtSluice).capacity;

            //----
            WmDailyWaterLevelAndissue wmDailyWaterLevelAndissue = new WmDailyWaterLevelAndissue(); 


            //---------------------------Effective head------------------------------------------------ -
            //EffectiveHead = Water Level at sluice - Sil Level
            //                             280.20 - 244 = 36.20


            double silLevel = 244;  //this is a fixed value                                   
            double effectiveHead = 0;
            effectiveHead = (double)wmDailyWaterLevelAndissueVM.WarterLevelAtSluice - silLevel;

            wmDailyWaterLevelAndissue.TankName = tankName;
            wmDailyWaterLevelAndissue.WaterIssuingConsiderDate = wmDailyWaterLevelAndissueVM.WaterIssuedDurationFromDateWithTime;
            wmDailyWaterLevelAndissue.WaterIssuedDurationFromDateWithTime = wmDailyWaterLevelAndissueVM.WaterIssuedDurationFromDateWithTime;
            wmDailyWaterLevelAndissue.WaterIssuedDurationToDateWithTime = wmDailyWaterLevelAndissueVM.WaterIssuedDurationToDateWithTime;

            wmDailyWaterLevelAndissue.EffectiveHead = (decimal)effectiveHead;
            wmDailyWaterLevelAndissue.Capacity = tankCapacity;

            wmDailyWaterLevelAndissue.WarterLevelAtSluice = wmDailyWaterLevelAndissueVM.WarterLevelAtSluice;
            wmDailyWaterLevelAndissue.GateOpenedSize = wmDailyWaterLevelAndissueVM.GateOpenedSize;
            wmDailyWaterLevelAndissue.WaterIssuedInAcft = 0;

            //=========================================Time Manipulation===========================================

            var timeStamp = wmDailyWaterLevelAndissueVM.WaterIssuedDurationToDateWithTime
                            .Subtract(wmDailyWaterLevelAndissueVM.WaterIssuedDurationFromDateWithTime);


            var totMinutes = timeStamp.TotalMinutes;
            int hrs = timeStamp.Hours;
            int remainingMinutes = (int)totMinutes - (hrs * 60);

            //==============Time duration pass to DB=======================================================================
            wmDailyWaterLevelAndissue.NoOfHours = (decimal)double.Parse((hrs.ToString() + "." + remainingMinutes.ToString()));
            //================================================================================================================





            ///calculating minutes as considering 100
            ///15mins = 25 ,  30mins = 50  , 45mins = 75
            ///how to solve this
            double oneUnit = (double)100 / 60;            
            ///Result = 1.67


            //this minutes is souite for formula.......
            double minutesAsUnits = 0;
            minutesAsUnits = (double)remainingMinutes * oneUnit;

            //two decimal points
            minutesAsUnits = Math.Round(minutesAsUnits, 0);




            //==============Time duration pass to formula===================================================
            double timeDurationPassToFormula = double.Parse((hrs.ToString()+"." + minutesAsUnits.ToString()));
            //=====================================================================================================



            //======================CALCULATING WATER ISSUED============================

            double waterIssued = 0;
            try
            {

                waterIssued = (double)9.92 * 3.5 * ((double)wmDailyWaterLevelAndissue.GateOpenedSize / 12) *
                            Math.Sqrt((double)wmDailyWaterLevelAndissue.EffectiveHead) * ((double)timeDurationPassToFormula / 24);
            }
            catch (Exception ee)
            {
                //MessageBox.Show("A problem occured :" + ee.Message);
            }
            wmDailyWaterLevelAndissue.WaterIssuedInAcft = (decimal)waterIssued;

            

            //Updating database-------
            _waterIssueRepository.AddWaterIssue(wmDailyWaterLevelAndissue);




            //return Content("Hrs :"+hrs+" , remaining minutes :"+remainingMinutes+ " minutesForFormula :"+ minutesAsUnits+" timeDurationForFormula :"+ timeDurationPassToFormula+" water Issued :::"+ wmDailyWaterLevelAndissue.WaterIssuedInAcft);
            //return Content("TimeDurationForFormula :" + timeDurationPassToFormula
            //    + " Effective Head " + wmDailyWaterLevelAndissueVM.EffectiveHead
            //    + " Water Issued :::" + wmDailyWaterLevelAndissueVM.WaterIssuedInAcft);


            //return Json(wmDailyWaterLevelAndissue);

            return PartialView("PartialWaterIssued", wmDailyWaterLevelAndissue); 
        }



       
    }
}
