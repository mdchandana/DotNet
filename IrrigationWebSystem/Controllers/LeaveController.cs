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
    public class LeaveController : Controller
    {
        private IEmployeeLeaveRepository _employeeLeaveRepository;
        private IEmployeeRepository _employeeRepository;
        private IPositionRepository _positionRepository;

        public LeaveController(IEmployeeLeaveRepository employeeLeaveRepository,IEmployeeRepository employeeRepository
                                , IPositionRepository positionRepository)
        {
            _employeeLeaveRepository = employeeLeaveRepository;
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

            var employeeLeaveVM = new EmployeeLeaveVM()
            {
                EmployeePositions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position"),
                Employees = new SelectList(_employeeRepository.GetEmployees(), "EmployeeId", "NameWithInitial")
            };



            return View();
        }


        [HttpPost]
        public ActionResult Create(EmployeeLeaveVM empLeaveVM)
        {
            return View();
        }
    }
}
