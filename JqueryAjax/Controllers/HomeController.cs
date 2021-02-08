﻿using JqueryAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Controllers
{
    public class HomeController : Controller
    {       

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult DateTimeTest()
        {
            return View("DateTimeTestView");
        }
    }
}
