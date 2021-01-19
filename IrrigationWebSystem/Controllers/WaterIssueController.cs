using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using IrrigationWebSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
            var wmDailyWaterLevelAndissueVM = new WmDailyWaterLevelAndissueVM()
            {
                WaterIssuingConsiderDate = DateTime.Today,
                WaterIssuedDurationFromDateWithTime=DateTime.Today,
                WaterIssuedDurationToDateWithTime=DateTime.Today
            };

            return View(wmDailyWaterLevelAndissueVM);
        }


        [HttpPost]
        public ActionResult Create(WmDailyWaterLevelAndissueVM wmDailyWaterLevelAndissueVM)
        {
            string tankName = "Muruthawela";
            
            //get capacity by level
            int tankCapacity = _waterLevelCapacityRepository
                                .GetMuruthawelaWaterCapacityByLevel(wmDailyWaterLevelAndissueVM.WarterLevelAtSluice).capacity;


            

            //---------------------------Effective head------------------------------------------------ -
            //EffectiveHead = Water Level at sluice - Sil Level
            //                             280.20 - 244 = 36.20


            double silLevel = 244;  //this is a fixed value                                   
            double effectiveHead = 0;
            effectiveHead = (double)wmDailyWaterLevelAndissueVM.WarterLevelAtSluice - silLevel;


            wmDailyWaterLevelAndissueVM.EffectiveHead = (decimal)effectiveHead;
            wmDailyWaterLevelAndissueVM.Capacity = tankCapacity;

            wmDailyWaterLevelAndissueVM.WaterIssuedInAcft = 0;


            //=========================================Time Manipulation===========================================

            var timeStamp = wmDailyWaterLevelAndissueVM.WaterIssuedDurationToDateWithTime
                            .Subtract(wmDailyWaterLevelAndissueVM.WaterIssuedDurationFromDateWithTime);


            var totMinutes = timeStamp.TotalMinutes;
            int hrs = timeStamp.Hours;
            int remainingMinutes = (int)totMinutes - (hrs * 60);


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

                waterIssued = (double)9.92 * 3.5 * ((double)wmDailyWaterLevelAndissueVM.GateOpenedSize / 12) *
                            Math.Sqrt((double)wmDailyWaterLevelAndissueVM.EffectiveHead) * ((double)timeDurationPassToFormula / 24);
            }
            catch (Exception ee)
            {
                //MessageBox.Show("A problem occured :" + ee.Message);
            }
            wmDailyWaterLevelAndissueVM.WaterIssuedInAcft = (decimal)waterIssued;








            //return Content("Hrs :"+hrs+" , remaining minutes :"+remainingMinutes+ " minutesForFormula :"+ minutesAsUnits+" timeDurationForFormula :"+ timeDurationPassToFormula+" water Issued :::"+ wmDailyWaterLevelAndissue.WaterIssuedInAcft);
            return Content("TimeDurationForFormula :" + timeDurationPassToFormula
                + " Effective Head " + wmDailyWaterLevelAndissueVM.EffectiveHead
                + " Water Issued :::" + wmDailyWaterLevelAndissueVM.WaterIssuedInAcft);
        }



        void CalculateIssue()
        {
            //string tankName = "";
            //DateTime waterIssueConsiderDate = DateTime.Today;
            //decimal waterLevelAtSluice = 280.20m; //--------------------------------------------------------------------taking by userInput




            ////get capacity by level
            //int tankCapacity = _waterLevelCapacityRepository
            //                    .GetMuruthawelaWaterCapacityByLevel(waterLevelAtSluice).capacity;


            //WmDailyWaterLevelAndissue wmDailyWaterLevelAndissue = new WmDailyWaterLevelAndissue();

            //---------------------------Effective head-------------------------------------------------
            //EffectiveHead=Water Level at sluice - Sil Level
            //                             280.20 - 244 = 36.20


            //double silLevel = 244;  //this is a fixed value                                   
            //double effectiveHead = 0;
            //effectiveHead = waterLevelAtSluice - silLevel;

            //wmDailyWaterLevelAndissue.WarterLevelAtSluice = (decimal)waterLevelAtSluice;
            //wmDailyWaterLevelAndissue.EffectiveHead = (decimal)effectiveHead;
            //wmDailyWaterLevelAndissue.Capacity = tankCapacity;
            //wmDailyWaterLevelAndissue.EffectiveHead = (decimal)effectiveHead;


            //------------------------------Gate opening------------------------------------------------
            //wmDailyWaterLevelAndissue.GateOpenedSize = 0;
            ////issue ACFT
            //wmDailyWaterLevelAndissue.WaterIssuedInAcft = 0;


            ////------------------------------Gate opening------------------------------------------------
            //waterLevelAndIssuedBean.GateOpenedSize = double.Parse(this.txtGateOpened.Text.ToString());

            ////======================CALCULATING WATER ISSUED============================

            //double waterIssued = 0;
            //try
            //{

            //    waterIssued = (double)9.92 * 3.5 * (waterLevelAndIssuedBean.GateOpenedSize / 12) *
            //                Math.Sqrt(waterLevelAndIssuedBean.EffectiveHead) * (waterLevelAndIssuedBean.NoOfHoursForFormula / 24);
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show("A problem occured :" + ee.Message);
            //}
            //waterLevelAndIssuedBean.WaterIssuedInACFT = waterIssued;
        }
    }
}
