using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VenkatCore.Models;
using VenkatCore.ViewModels;

namespace VenkatCore.Controllers
{

    /* ---------------------------------Dependancy Injection------------------------------------------
      * Our Home controller has a Dependency  on the service by IEmployeeRepository -
      * This Home controller is not creating a instance of this Dependancy using this new keyword -
      * instead we are injecting this IEmployeeRepository into the Home Controller using it's constructor - 
      * So this is called Constructor Injection.........
      **/

    /* 
     * When someone request IEmployeeRepository service we want asp.net core to create -
     * a instance of MockEmployeeRepository class and inject that instance into the controller..
     * But by default asp.net core dependancy injection system will not be able to do that,
     * we'll have to register our interface that is IEmployeeRepository and it's implementations -
     * in this case MockEmployeeRepository class with Asp.net core Dependancy injection container,
     * we do that in Startup.cs file......
     */

    /*Here using the Constructor to inject the service IEmployeeRepository, -
    * This is called Constructor Injection..
    */

    /* So there were 2 Steps
           1. Defining a constructor parameter
           2. Reegister Dependancy with Dependancy Injection Container
     */

    /*-----Benefit Of Di--------
     * Loose Coupling
     * Easy to Unit Tect
     */


    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;  

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            //_departmentRepository = departmentRepository;
        }
        public ViewResult Index()
        {           
            //var deptList = _departmentRepository.GetDepartments().ToList();
            //deptList.Insert(0, new Department() { Id = 0, DeptName = "Select" });           
            //ViewBag.DeptList=deptList;                    

            //var abc=HttpContext.RequestServices.GetService(typeof(IDepartmentRepository));
            

            return View(_employeeRepository.GetEmployees());
        }
               
        [HttpGet]
        public ViewResult Details()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        
        [HttpGet]
        public ViewResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddOrEdit()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Delete(int id)
        {
            return View();
        }

    }
}