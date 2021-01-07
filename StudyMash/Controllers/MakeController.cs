using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudyMash.Infrastructure.Data.Context;
using StudyMash.Models;

namespace StudyMash.Controllers
{
    public class MakeController : Controller
    {
        private AppDbContext _appDbContext;

        public MakeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }



        public ActionResult Index()
        {
            var makeList = _appDbContext.Makes.ToList();

            return View(makeList);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Make make)
        {
            if(ModelState.IsValid)
            {
                _appDbContext.Makes.Add(make);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);
        }



        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Make make)
        {
            return View();
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            return View();
        }


        [HttpPost]
        [ActionName(nameof(Delete))]
        public ActionResult Delete_Post(int? id)
        {
            return View();
        }

    }
}