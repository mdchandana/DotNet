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
            if (ModelState.IsValid)
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
            if (id == null)
                return BadRequest("Make Id cannot be Empty..");

            var foundMake = _appDbContext.Makes.Find(id);

            if (foundMake == null)
                return NotFound($"Cannot find the Make with Id :{id}");


            return View(foundMake);
        }




        [HttpPost]
        public ActionResult Edit(int? id,Make makeChanges)
        {

            if (id == null)
                return BadRequest("Make Id cannot be Empty..");


            if (ModelState.IsValid)
            {
                var makeFound = _appDbContext.Makes.Find(id);
                if (makeFound == null)
                    return NotFound($"Cannot find the make with Id :{makeChanges.Id} ");
                else
                {
                    makeFound.Name = makeChanges.Name;
                    _appDbContext.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(makeChanges);
        }






        [HttpGet]
        public ActionResult Delete(int? id)
        {            

            if (id == null)
                return BadRequest("Make Id cannot be Empty...");

            var foundMake = _appDbContext.Makes.Find(id);
            if (foundMake == null)
                return NotFound($"Cannot find the Make with Id :{id}");

            return View(foundMake);
        }


        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post(int? id)
        {
            

            if (id == null)
                return BadRequest("Make Id cannot be Empty...");

            var foundMake = _appDbContext.Makes.Find(id);

            if (foundMake == null)
                return NotFound($"Cannot find the Make with Id :{id}");

            _appDbContext.Makes.Remove(foundMake);
            _appDbContext.SaveChanges();

            //return View();
            return RedirectToAction(nameof(Index));
        }

    }
}