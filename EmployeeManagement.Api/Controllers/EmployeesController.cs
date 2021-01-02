using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        //GET api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        //public async Task<ActionResult> GetEmployees()
        {

            //to add try catch block
            // try + Tab twice

            /*
             *  200-Ok   201-Created  
             *  400-Bad Request   401-Unauthorize    404-NotFound
             *  500 501 503 StatusCode
             */
            try
            {
                return Ok(await _employeeRepository.GetEmployees());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }

        }

        //GET api/Employees/1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var result = await _employeeRepository.GetEmployee(id);

            if (result == null)
            {
                return NotFound();
            }


            //Asp.net core automatically serialize to json object
            return result;
        }


        //GET api/Employees
        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {

            try
            {
                if (employee == null)
                {
                    return BadRequest();
                }

                var empByEmail = await _employeeRepository.GetEmployeeByEmail(employee.Email);
                if (empByEmail != null)
                {
                    ModelState.AddModelError("email", "Employee Email already in use");
                    return BadRequest(ModelState);
                }

                var createdEmployee = await _employeeRepository.AddEmployee(employee);

                return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.EmployeeId }, createdEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from database");
            }
        }

        //PUT api/Employees/1
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> Update(int id,Employee employee)
        {
            try
            {

                if(id != employee.EmployeeId)
                {
                    return BadRequest("EmployeeId mismatch");
                }


                var employeeToUpdate = await _employeeRepository.GetEmployee(id);                
                if(employeeToUpdate == null)
                {
                    return NotFound($"Employee with Id :{id} not found");
                }

                return await _employeeRepository.UpdateEmployee(employee);

                

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from database");
            }
        }


        //DELETE api/Employees/1
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {

            var employeeToDelete = await _employeeRepository.GetEmployee(id);
            if(employeeToDelete == null)
            {
                return NotFound($"Employee with Id :{id} doesn't exists");
            }

            return await _employeeRepository.DeleteEmployee(id);

        }







    }
}
