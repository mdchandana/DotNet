using JsonDotnetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonDotnetCore.Controllers
{
    [Route("[controller]")]
    //[Route("api/[controller]")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {

        private Employee _employee = null;
        private List<Employee> _employeeList = null;

        public EmployeeApiController()
        {

            _employee = new Employee() { Id = 2008, Name = "Madhawa", Address = "Benthota" };

            _employeeList = new List<Employee>()
            {
                 new Employee(){Id=2001,Name="Sidath",Address="Kamburupitiya"},
                 new Employee(){Id=2016,Name="Chandana",Address="Dickwella"},
                 new Employee(){Id=2047,Name="Yasiru",Address="JaEla"}
            };

        }





        // GET  https://localhost:44303/employeeApi/
        //      https://localhost:44303/employeeApi/        

        /*
         If you run the Get() action from the browser the Web API returns JSON data as shown below:
         Notice this output carefully. You will find that the property names have automatically -
         converted into their camel case equivalent. 
         For example, EmployeeID became employeeID and FirstName became firstName. 
         This means by default Web API serializes JSON data using camel casing.
         What if you don't want this automatic conversion? What if you want to maintain whatever - 
         casing is being used by your C# classes?
         Let's configure that behavior now. Open the Startup class and modify the ConfigureServices() method as shown below:

        */

        /*
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
         */




        [HttpGet]
        public List<Employee> Get()
        {
            return _employeeList;
        }





    }
}
