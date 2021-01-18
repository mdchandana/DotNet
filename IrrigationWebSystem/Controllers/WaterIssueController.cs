using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
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



        void CalculateIssue()
        {
            string tankName = "";
            DateTime waterIssueConsiderDate = DateTime.Today;
            decimal waterLevelAtSluice = 280.20m; //--------------------------------------------------------------------taking by userInput




            //get capacity by level
            int tankCapacity = _waterLevelCapacityRepository
                                .GetMuruthawelaWaterCapacityByLevel(waterLevelAtSluice).capacity;


            WmDailyWaterLevelAndissue wmDailyWaterLevelAndissue = new WmDailyWaterLevelAndissue();

            //---------------------------Effective head-------------------------------------------------
            //EffectiveHead=Water Level at sluice - Sil Level
            //                             280.20 - 244 = 36.20


            double silLevel = 244;  //this is a fixed value                                   
            double effectiveHead = 0;
            effectiveHead = waterLevelAtSluice - silLevel;

            wmDailyWaterLevelAndissue.WarterLevelAtSluice = (decimal)waterLevelAtSluice;
            wmDailyWaterLevelAndissue.EffectiveHead = (decimal)effectiveHead;
            wmDailyWaterLevelAndissue.Capacity = tankCapacity;
            wmDailyWaterLevelAndissue.EffectiveHead = (decimal)effectiveHead;


            //------------------------------Gate opening------------------------------------------------
            wmDailyWaterLevelAndissue.GateOpenedSize = 0;
            //issue ACFT
            wmDailyWaterLevelAndissue.WaterIssuedInAcft = 0;


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
