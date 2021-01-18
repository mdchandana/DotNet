using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Controllers
{
    public class LeaveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(EmpLeaveVM empLeaveVM)
        {
            return View();
        }
    }
}
