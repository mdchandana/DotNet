using JqueryAjax.Enums;
using JqueryAjax.Models;
using JqueryAjax.Models.DomainEntities;
using JqueryAjax.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace JqueryAjax.Controllers
{
    public class EmployeeController : Controller
    {

        
        private List<EmployeeVM> _employeeVmList = null;


        public EmployeeController()
        {

            _employeeVmList = new List<EmployeeVM>()
            {
                 new EmployeeVM(){EmpNumber="2001",NameWithInitial="Sidath",Address="Kamburupitiya", Gender=Gender.Male,BasicSalary=125000,Age=38, PositionId=1},
                 new EmployeeVM(){EmpNumber="2016",NameWithInitial="Chandana",Address="Dickwella", Gender=Gender.Male,BasicSalary=40000,Age=39, PositionId=2},
                 new EmployeeVM(){EmpNumber="2047",NameWithInitial="Yasiru",Address="Ragama", Gender=Gender.Male,BasicSalary=78000,Age=40, PositionId=3}
            };

        }


        [HttpGet]
        public IActionResult Index()
        {
            EmployeePosition empPosition = new EmployeePosition();


            var EmpVM = new EmployeeVM()
            {
                 EmployeePositions=new SelectList(empPosition.GetAllPositions(),"Id", "Position")
            };


            return View("EmployeeView", EmpVM);
        }

        [HttpPost]
        public JsonResult CreateEmployee(EmployeeVM employeeVM)
        {
            string status;

            if(ModelState.IsValid)
            {
                status = "Validation Successed and Created Employee";
            }
            else
            {
                status = "Validation Failed";
            }


            return Json(status);
        }


       

        [HttpGet]
        public IActionResult GetEmployees()
        {
           
            return Json("");
        }



        [HttpGet]
        public ActionResult GetEmployeeByEmpNumber(string empNumber)
        {
            var foundEmp = _employeeVmList.FirstOrDefault(emp => emp.EmpNumber == empNumber);

            if (empNumber == null)
                return BadRequest("EmployeeId cannot be null");

            if (foundEmp == null)
            {
                ModelState.AddModelError("myError", "fuck");
                return NotFound($"Employee with Id : {empNumber} Notfound");
                
            }
            return Json(foundEmp);
        }
    }
}


//[HttpPost]
//public ActionResult SaveCustomer(CustomerViewModel model)
//{
//    if (!ModelState.IsValid)
//    {
//        return PartialView("_MyForm", model);
//    }
//    return Json(new { success = true });
//}




//Try this code.This is a simple solution for your problem. It will join all the model state errors into one string.

//[HttpPost]
//    public ActionResult SaveCustomer(CustomerViewModel input)
//{
//    if (!ModelState.IsValid)
//    { // <-- business validation
//        return Json(new
//        {
//            success = false,
//            errors = string.Join("; ", ModelState.Values
//                                        .SelectMany(x => x.Errors)
//                                        .Select(x => x.ErrorMessage));
//    });
//        }
//        // persist 
//        return Json(new { success = true });
//    }











//----------------------------------------------
/*
Return MVC model state errors via AJAX
$.ajax({
    url: "/controller/action",
    data: data,
    contentType: 'application/json',
    dataType: 'json',
    type: "post",
    success: function (response) {
        if (response.success) {
    // do something clever
        } else {
            alert('An error occurred, please try again.');
        }
    }
});
 

As you can see the code doesn’t tell the user why an error occurred and what they might be able to do to correct it.
To improve this you could return the model state errors from the action and display them to the user:

[HttpPost]
public JsonResult Edit(EditModel model)
{
      if (!ModelState.IsValid)
      {
            return Json(new { success = false, issue = model, errors = ModelState.Values.Where(i => i.Errors.Count > 0) });
       }
 
       // perform save
}
-------------------------------------------------------------------------------
*/