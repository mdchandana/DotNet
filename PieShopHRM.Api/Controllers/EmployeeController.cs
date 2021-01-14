using Microsoft.AspNetCore.Mvc;
using PieShopHRM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(_employeeRepository.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeByEmpNumber(string empNumber)
        {
            return Ok(_employeeRepository.GetEmployeeByEmpNumber(empNumber));
        }
    }
}
