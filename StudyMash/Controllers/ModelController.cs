﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyMash.Infrastructure.Data.Context;
using StudyMash.Models;
using StudyMash.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMash.Controllers
{
    public class ModelController : Controller
    {
        private AppDbContext _appDbContext;

        public ModelController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var modelList = _appDbContext.Models.Include(m => m.Make).ToList();

            return View(modelList);
        }

        [HttpGet]
        public ActionResult Create()
        {           
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(Model vehicleModel)
        {
            var makeList = _appDbContext.Makes.ToList();
            makeList.Insert(0, new Make() { Id = 0, Name = "Select" });
            ViewBag.MakeList = makeList;



            return View();
        }

    }
}
