using JsonDotnetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonDotnetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("JsonDotnetCore - HomeController Index method called..");
        }




        [HttpGet]
        public JsonResult Index2()
        {
            var empList=new List<Employee>()
            {
                 new Employee(){Id=2001,Name="Sidath",Address="Kamburupitiya"},
                 new Employee(){Id=2016,Name="Chandana",Address="Dickwella"},
                 new Employee(){Id=2047,Name="Yasiru",Address="JaEla"}
            };
            return Json(empList);
        }

    }
}
