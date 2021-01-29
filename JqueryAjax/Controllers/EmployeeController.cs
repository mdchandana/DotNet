using JqueryAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace JqueryAjax.Controllers
{
    public class EmployeeController : Controller
    {

        private Employee _employee = null;
        private List<Employee> _employeeList = null;


        public EmployeeController()
        {

            _employee = new Employee() { Id = 2008, Name = "Madhawa", Address = "Benthota" };

            _employeeList = new List<Employee>()
            {
                 new Employee(){Id=2001,Name="Sidath",Address="Kamburupitiya"},
                 new Employee(){Id=2016,Name="Chandana",Address="Dickwella"},
                 new Employee(){Id=2047,Name="Yasiru",Address="JaEla"}
            };

        }

        public IActionResult Index()
        {
            return View();
        }



       

        [HttpGet]
        public IActionResult GetEmployees()
        {
           
            return Json(_employeeList);
        }



        [HttpGet]
        public ActionResult GetEmployeeById(int? id)
        {
            var foundEmp = _employeeList.FirstOrDefault(emp => emp.Id == id);

            if (id == null)
                return BadRequest("EmployeeId cannot be null");

            if (foundEmp == null)
            {
                ModelState.AddModelError("myError", "fuck");
                return NotFound($"Employee with Id : {id} Notfound");
                
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