using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using IrrigationWebSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private ICannelRepository _cannelRepository;
        private ICannelWaterIssueRepository _cannelWaterIssueRepository;

        public WaterIssueController(IWaterIssueRepository waterIssueRepository,
                                    IWaterLevelCapacityMuruthawelaTank waterLevelCapacityRepository,
                                    ICannelRepository cannelRepository,
                                    ICannelWaterIssueRepository cannelWaterIssueRepository)
        {
            _waterIssueRepository = waterIssueRepository;
            _waterLevelCapacityRepository = waterLevelCapacityRepository;
            _cannelRepository = cannelRepository;
            _cannelWaterIssueRepository = cannelWaterIssueRepository;
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



        //[AcceptVerbs("Get", "Post")]
        //public JsonResult IsWaterlevelCorrect(decimal waterlevel)
        //{
            

        //    //here status true mean , not displaying a validation message
        //    bool status = false;

        //    ////Worked.. status = false mean userName is not available, alrady taken
        //    //var foundUser = user.GetAllUsers().Find(u => u.UserName == UserName);
        //    //if (foundUser != null)
        //    //    status = false;

        //    ////Worked.. status = false mean userName is not available, alrady taken
        //    //userName already taken
        //    //client side validation displaying
        //    //if (_waterLevelCapacityRepository.GetAllWaterlevels().Any(w => w.WaterLevel == waterlevel))
        //    //{
        //    //    status = true;
        //    //}

        //    //Less than zero d1 is less than d2.
        //    //Zero d1 and d2 are equal.
        //    //Greater than zero d1 is greater than d2.

        //    int compareResult = 1;

        //    foreach(var level in _waterLevelCapacityRepository.GetAllWaterlevels())
        //    {
        //        compareResult=decimal.Compare(level.WaterLevel, waterlevel);
        //    }

            
        //    if(compareResult==0)
        //    {
        //        status = true;
        //    }



        //    return Json(status);
        //}








        [HttpPost]
        public ActionResult Create(WmDailyWaterLevelAndissueVM wmDailyWaterLevelAndissueVM)
        {
            string tankName = "Muruthawela";
            
            //Get capacity by water level --- accessing Database
            int tankCapacity = _waterLevelCapacityRepository
                                .GetMuruthawelaWaterCapacityByLevel(wmDailyWaterLevelAndissueVM.WarterLevelAtSluice).capacity;

           //Instantiation
            WmDailyWaterLevelAndissue wmDailyWaterLevelAndissue = new WmDailyWaterLevelAndissue(); 


            //---------------------------Effective head------------------------------------------------ -
            //EffectiveHead = Water Level at sluice - Sil Level
            //                             280.20 - 244 = 36.20


            double silLevel = 244;  //---------Sill Level This is a fixed value                                   
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

            //======================================Time duration pass to DB===============================================
            wmDailyWaterLevelAndissue.NoOfHours = (decimal)double.Parse((hrs.ToString() + "." + remainingMinutes.ToString()));
            //=============================================================================================================





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




            //====================================Time duration pass to formula=======================================
            double timeDurationPassToFormula = double.Parse((hrs.ToString()+"." + minutesAsUnits.ToString()));
            //========================================================================================================



            //======================CALCULATING WATER ISSUED================================
            //===============================FORMULA========================================
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

        
        [HttpGet]
        public ActionResult GetWaterIssuesForPeriod()
        {
            var dateStart = DateTime.Now.AddMonths(-1);
            var dateEnd = DateTime.Today;

            WmWaterIssuesForPeriodVM wmWaterIsuueForPeriod = new WmWaterIssuesForPeriodVM()
            {
                DurationStart = dateStart,
                DurationEnd = dateEnd,
                WmDailyWaterLevelAndissueVMs = _waterIssueRepository.GetWaterIssuesForPeriod(dateStart, dateEnd)
                                                .Select(waterIssueVm => new WmDailyWaterLevelAndissueVM()
                                                {
                                                    WaterIssuingConsiderDate= waterIssueVm.WaterIssuingConsiderDate,
                                                    WarterLevelAtSluice=waterIssueVm.WarterLevelAtSluice,
                                                    EffectiveHead=waterIssueVm.EffectiveHead,
                                                    Capacity=waterIssueVm.Capacity,                                                    
                                                    WaterIssuedDurationFromDateWithTime=waterIssueVm.WaterIssuedDurationFromDateWithTime,
                                                    WaterIssuedDurationToDateWithTime = waterIssueVm.WaterIssuedDurationToDateWithTime,
                                                    NoOfHours = waterIssueVm.NoOfHours,
                                                    GateOpenedSize = waterIssueVm.GateOpenedSize,
                                                    WaterIssuedInAcft =waterIssueVm.WaterIssuedInAcft
                                                }).ToList()
            };

            return View(wmWaterIsuueForPeriod);
        }


       
        [HttpPost]
        public ActionResult GetWaterIssuesForPeriod(DateTime startDate,DateTime endDate)
        {
            var waterIssueForPeriod=_waterIssueRepository.GetWaterIssuesForPeriod(startDate, endDate);

            WmWaterIssuesForPeriodVM wmWaterIsuueForPeriod = new WmWaterIssuesForPeriodVM()
            {
                
                WmDailyWaterLevelAndissueVMs = _waterIssueRepository.GetWaterIssuesForPeriod(startDate, endDate)
                                                .Select(waterIssueVm => new WmDailyWaterLevelAndissueVM()
                                                {
                                                    WaterIssuingConsiderDate = waterIssueVm.WaterIssuingConsiderDate,
                                                    WarterLevelAtSluice = waterIssueVm.WarterLevelAtSluice,
                                                    EffectiveHead = waterIssueVm.EffectiveHead,
                                                    Capacity = waterIssueVm.Capacity,
                                                    WaterIssuedDurationFromDateWithTime = waterIssueVm.WaterIssuedDurationFromDateWithTime,
                                                    WaterIssuedDurationToDateWithTime = waterIssueVm.WaterIssuedDurationToDateWithTime,
                                                    NoOfHours = waterIssueVm.NoOfHours,
                                                    GateOpenedSize = waterIssueVm.GateOpenedSize,
                                                    WaterIssuedInAcft = waterIssueVm.WaterIssuedInAcft
                                                }).ToList()
            };

            return PartialView("PartialwaterIssuesForPeriod", wmWaterIsuueForPeriod);
        }






        [HttpGet]
        public ActionResult MuruthawelaCannelsWaterIssue()
        {
            var CannelWaterIssueVM = new WmCannelsWaterIssuVM()
            {
                 CannelNames=new SelectList(_cannelRepository.GetAllCannels(), "CannelName", "CannelName")
            };


            return View("CannelsWaterIssueView", CannelWaterIssueVM);
        }



        [HttpPost]
        public JsonResult MuruthawelaCannelsWaterIssue(WmCannelsWaterIssuVM wmCannelsWaterIssuVM)
        {

            return Json("");
        }








        private double CalculateMuruthawelaCannelWaterIssue(string cannelName, double guageHeight, DateTime startTime,DateTime endTime)
        {
            
            double H = guageHeight;
            double resultCumecs = 0;
            double resultReturning = 0;

            if(cannelName.Equals("LB-Main-Cannel"))
            {
                //Main cannel worked----------------------
                
                var issueResult = H - 0.385;
                resultCumecs = Math.Pow(issueResult, 1.34) * 5.3785;
                
            }
            else if (cannelName.Equals("Track-02-D4"))
            {
                //Track 02 D4----------------------
                var track2D4Result1 = H * 0.1405 - (0.00009);
                var powerH = Math.Pow(H, 2);
                var track2D4Result2 = 0.963 * powerH;
                resultCumecs = track2D4Result1 + track2D4Result2;
               
            }
            else if (cannelName.Equals("Track-02-D6"))
            {
                ////Track 02 D6----------------------
                var track2D6Result1 = H - 0.04;
                var powerH_track2D6Result1 = Math.Pow(track2D6Result1, 1.0506);
                resultCumecs = 0.8298 * powerH_track2D6Result1;

            }
            else if (cannelName.Equals("Track-01-D2"))
            {
                //Track 01 D2----------------------               
                var powerH = Math.Pow(H, 2);
                var track1D2Result1 = 0.0548 * H + 0.0002;
                var track1D2Result2 = 1.3095 * powerH;
                resultCumecs = track1D2Result1 + track1D2Result2;  
                
            }
            else if (cannelName.Equals("Track-02-D8"))
            {
                //Track 02 D8----------------------                
                var powerH = Math.Pow(H, 2);
                var track2D8Result1 = 1.3878 * powerH;
                resultCumecs = track2D8Result1 + (0.6583 * H) - 0.0019;
               
            }
            else if (cannelName.Equals("Track-02-FC-01"))
            {
                //Track 02 FC 01----------------------                
                var powerH = Math.Pow(H, 2);
                var track2FC1Result1 = 5.4662 * powerH;
                resultCumecs = track2FC1Result1 + (0.6308 * H) - 0.0003;              

            }
            else if (cannelName.Equals("Track-02-D9"))
            {
                //Track 02 D9----------------------                
                var powerH = Math.Pow(H, 2);
                var track2D92Result1 = 1.6506 * powerH;
                resultCumecs = track2D92Result1 - (0.0948 * H) - 0.0026;     
                
            }
            else if (cannelName.Equals("Track-03-D2"))
            {
                //Track 03 D2----------------------                
                var powerH = Math.Pow(H, 2);
                var track3D2Result1 = 0.2756 * powerH;
                resultCumecs = track3D2Result1 + (0.4663 * H) + 0.0039;    
                
            }
            else if (cannelName.Equals("Track-03-D3"))
            {
                //Track 03 D3----------------------               
                var track3D3Result1 = H - 0.025;
                var powerH = Math.Pow(track3D3Result1, 2.6567);
                resultCumecs = 3.984 * powerH;                

            }
            else if (cannelName.Equals("Track-03-D5"))
            {
                //Track 03 D5----------------------                
                var powerH = Math.Pow(H, 2);
                resultCumecs = (1.0216 * powerH) - (0.0023 * H) - 0.0001;

            }
            else if (cannelName.Equals("Track-03-D6"))
            {
                ////Track 03 D6-----------------   ===============  Program Result not tally to given result by doc
                var powerH = Math.Pow(H, 2);
                resultCumecs = (0.7649 * powerH) + (0.1106 * H) - 0.0041;
               
            }
            else if (cannelName.Equals("Track-03-D9"))
            {
                //Track 03 D9-----------------                  
                var powerH = Math.Pow(H, 2);
                resultCumecs = (4.039 * powerH) + (0.0152 * H) + 0.0014;
            }




            resultReturning = Math.Round(resultCumecs, 3);

            return resultReturning;

        }





    }
}
