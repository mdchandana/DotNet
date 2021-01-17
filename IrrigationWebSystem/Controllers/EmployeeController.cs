using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using IrrigationWebSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private IPositionRepository _positionRepository;

        public EmployeeController(IEmployeeRepository employeeRepository, IPositionRepository positionRepository)
        {
            _employeeRepository = employeeRepository;
            _positionRepository = positionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Positions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position");

            Employee foundEmployee = _employeeRepository.GetEmployeeByEmpNumber("538");
                                                        
            EmployeeVM employeeVM = new EmployeeVM()
            {
                EmpNumber = foundEmployee.EmpNumber,
                Nic = foundEmployee.Nic,
                PersonalFileNumber = foundEmployee.PersonalFileNumber,
                NameWithInitial = foundEmployee.NameWithInitial,
                FullName=foundEmployee.FullName,
                EmployeePositionId=foundEmployee.EmployeePositionId,
                Gender = foundEmployee.Gender,
                CivilStatus=foundEmployee.CivilStatus,
                Address = foundEmployee.Address

            };

            return View(employeeVM);
        }

        [HttpPost]
        public ActionResult Create(EmployeeVM employeeVM)
        {
            ViewBag.Positions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position");
            return View();
        }
    }
}
