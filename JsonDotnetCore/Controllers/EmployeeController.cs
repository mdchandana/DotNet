using JsonDotnetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonDotnetCore.Controllers
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
        public JsonResult GetEmployees1()
        {

            return Json(_employeeList);
        }









        /*
         =========================Camel casing and MVC controllers====================
         In ASP.NET Core MVC you can use Json() method to serialize data JSON format. 
         Consider the following action that shows how this can be done.
         The Index() action creates a List of Employee objects. 
         The empList is then serialized to the client using Json() method.
         
         -------------------------
         0	
            id	2001
            name	"Sidath"
            address	"Kamburupitiya"
        1	
            id	2016
            name	"Chandana"
            address	"Dickwella"
        2	
            id	2047
            name	"Yasiru"
            address	"JaEla"       
        ---------------------------

         As you can see the property names use camel casing. This behavior is similar to the Web API behavior.
         In order to instruct MVC to stop using camel casing you can write this code in the ConfigureServices().

            services.AddControllersWithViews()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions
                .PropertyNamingPolicy = null;
            });

       ----------------------------
        0	
            Id	2001
            Name	"Sidath"
            Address	"Kamburupitiya"
        1	
            Id	2016
            Name	"Chandana"
            Address	"Dickwella"
        2	
            Id	2047
            Name	"Yasiru"
            Address	"JaEla"
       -----------------------------
         

         */

        [HttpGet]
        public IActionResult GetEmployees2()
        {

            //var options = new JsonSerializerOptions()
            //{
            //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            //};

            //disabling camelCase , withing controller method
            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = null
            };


            return Json(_employeeList, options);
        }








        /* =================Custom code using JsonSerializer========================
         At times you need to serialize data yourself via custom code.Typically you will use - 
         JsonSerializer to accomplish this task.Consider the following code:
         Here you used JsonSerializer class to serialize empList to JSON string. 
         The string is then returned to the client by wrapping it in the Ok() method.

         As you can see, the Serialize() method of JsonSerializer doesn't use camel casing by default.
         */

        [HttpGet]
        public IActionResult GetEmployees3()
        {
            /*System.Text.Json is the built -in JavaScript Object Notation(JSON) serialization library in .NET for 
            * converting from .NET object types to a JSON string, and vice versa, supporting UTF - 8 text encoding.*/

            ///Worked --
            ///JsonSerializer doesn't use camel casing by default  
            string jsonList = JsonSerializer.Serialize(_employeeList);



            ///Worked --
            ///Set Explicitely camel casing
            //var options = new JsonSerializerOptions()
            //{
            //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            //};
            //string jsonList = JsonSerializer.Serialize(_employeeList,options);


            return Ok(jsonList);
        }









        public IActionResult GetEmployeeById(int? id)
        {
            var foundEmp = _employeeList.FirstOrDefault(emp => emp.Id == id);

            if (id == null)
                return BadRequest("EmployeeId cannot be null");

            if (foundEmp == null)
                return NotFound($"Employee with Id : {id} Notfound");


            return Json(foundEmp);
        }
    }
}
