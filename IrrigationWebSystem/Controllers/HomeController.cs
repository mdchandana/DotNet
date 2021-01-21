using IrrigationWebSystem.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Controllers
{
    public class HomeController : Controller
    {
        private IPositionRepository _positionRepository;

        public HomeController(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
             return View();
        }


        [HttpPost]
        public IActionResult Test()
        {
            string result = "";

            try
            {
                var positions = _positionRepository.GetAllPositions().ToList();
                result = positions.Count.ToString();
            }
            catch (Exception e)
            {
                result += e.Message + "\t" + e.Source + "\t" + e.InnerException;
            }


            return Content(result);
        }



    }
}
