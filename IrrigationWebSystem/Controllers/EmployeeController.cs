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
            var employeesVM = _employeeRepository.GetEmployees()
                                        .Select(emp => new EmployeeVM()
                                        {
                                            EmployeeId = emp.EmployeeId,
                                            EmpNumber = emp.EmpNumber,
                                            Nic = emp.Nic,
                                            PersonalFileNumber = emp.PersonalFileNumber,
                                            NameWithInitial = emp.NameWithInitial,
                                            FullName = emp.FullName,
                                            SurName = emp.SurName,
                                            EmployeePosition = emp.EmployeePosition,
                                            Gender = emp.Gender,
                                            CivilStatus = emp.CivilStatus,
                                            Address = emp.Address,
                                            //ContactNumber1 = emp.EmployeeContacts.ToList()[0].ToString(),
                                            Email = emp.Email,
                                            DateOfBirth = emp.DateOfBirth,
                                            AppointmentDate = emp.AppointmentDate,
                                            BasicSalary = emp.BasicSalary,
                                            CurrentlyWorkingStatus = emp.CurrentlyWorkingStatus,
                                            ClassMnGrade = emp.ClassMnGrade

                                        }).ToList();


            //var employeeListVM1= new EmployeeListVM()
            //{
            //    EmployeePositions2 = _positionRepository.GetAllPositions().Select(p => new SelectListItem()
            //                        {
            //                            Value=p.Id.ToString(),
            //                            Text=p.Position

            //                        }).ToList(),

            //    EmployeesVMs= employeesVM
            //};



            var employeeListVM = new EmployeeListVM()
            {
                EmployeePositions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position"),

                EmployeesVMs = employeesVM
            };



            return View(employeeListVM);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Positions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position");            

            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeVM employeeVM)
        {
            ViewBag.Positions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position");

            if(ModelState.IsValid)
            {
                Employee employee = new Employee
                {
                    EmpNumber = employeeVM.EmpNumber,
                    Nic = employeeVM.Nic,
                    PersonalFileNumber = employeeVM.PersonalFileNumber,
                    NameWithInitial = employeeVM.NameWithInitial,
                    FullName = employeeVM.FullName,
                    SurName = employeeVM.SurName,
                    EmployeePositionId = employeeVM.EmployeePositionId,
                    Gender = employeeVM.Gender,
                    CivilStatus = employeeVM.CivilStatus,
                    Address = employeeVM.Address,
                    //ContactNumber1 = foundEmployee.EmployeeContacts.ToList()[0].ToString(),
                    Email = employeeVM.Email,
                    DateOfBirth = employeeVM.DateOfBirth,
                    AppointmentDate = employeeVM.AppointmentDate,
                    BasicSalary = employeeVM.BasicSalary,
                    CurrentlyWorkingStatus = employeeVM.CurrentlyWorkingStatus,
                    ClassMnGrade = employeeVM.ClassMnGrade
                };

                _employeeRepository.AddEmployee(employee);

            }


            return View();
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {

            ViewBag.Positions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position");

            EmployeeVM employeeVM = null;

            if (id.ToString() == null)
                return BadRequest("EmployeeId cannot be Empty");

            var foundEmployee = _employeeRepository.GetEmployeeByEmpId(id);
            if (foundEmployee == null)
                return NotFound($"Employee with EmployeeId {id} Not found");
            else
            {
                employeeVM = new EmployeeVM
                {
                    EmployeeId = foundEmployee.EmployeeId,
                    EmpNumber = foundEmployee.EmpNumber,
                    Nic = foundEmployee.Nic,
                    PersonalFileNumber = foundEmployee.PersonalFileNumber,
                    NameWithInitial = foundEmployee.NameWithInitial,
                    FullName = foundEmployee.FullName,
                    SurName = foundEmployee.SurName,
                    EmployeePositionId = foundEmployee.EmployeePositionId,
                    Gender = foundEmployee.Gender,
                    CivilStatus = foundEmployee.CivilStatus,
                    Address = foundEmployee.Address,
                    //ContactNumber1 = foundEmployee.EmployeeContacts.ToList()[0].ToString(),
                    Email = foundEmployee.Email,
                    DateOfBirth = foundEmployee.DateOfBirth,
                    AppointmentDate = foundEmployee.AppointmentDate,
                    BasicSalary = foundEmployee.BasicSalary,
                    CurrentlyWorkingStatus = foundEmployee.CurrentlyWorkingStatus,
                    ClassMnGrade = foundEmployee.ClassMnGrade
                };
            }

            return View(employeeVM);
        }




        [HttpPost]
        public ActionResult Edit(int employeeId,EmployeeVM employeeVMChanges)
        {
            if (employeeId.ToString() == null)
                return BadRequest("EmployeeId cannot be Empty");

            if(ModelState.IsValid)
            {
                var foundEmployee = _employeeRepository.GetEmployeeByEmpId(employeeId);
                if (foundEmployee == null)
                    return NotFound($"Employee with EmployeeId {employeeId} Not found");
                else
                {
                    foundEmployee.EmpNumber = employeeVMChanges.EmpNumber;
                    foundEmployee.Nic= employeeVMChanges.EmpNumber;
                    foundEmployee.PersonalFileNumber = employeeVMChanges.PersonalFileNumber;
                    foundEmployee.NameWithInitial = employeeVMChanges.NameWithInitial;
                    foundEmployee.FullName = employeeVMChanges.FullName;
                    foundEmployee.SurName = employeeVMChanges.SurName;
                    foundEmployee.EmployeePositionId = employeeVMChanges.EmployeePositionId;
                    foundEmployee.Gender = employeeVMChanges.Gender;
                    foundEmployee.CivilStatus = employeeVMChanges.CivilStatus;
                    foundEmployee.Address = employeeVMChanges.Address;
                    //foundEmployee.EmployeeContacts.ToList()[0].ToString(),
                    foundEmployee.Email = employeeVMChanges.Email;
                    foundEmployee.DateOfBirth = employeeVMChanges.DateOfBirth;
                    foundEmployee.AppointmentDate = employeeVMChanges.AppointmentDate;
                    foundEmployee.BasicSalary = employeeVMChanges.BasicSalary;
                    foundEmployee.CurrentlyWorkingStatus = employeeVMChanges.CurrentlyWorkingStatus;
                    foundEmployee.ClassMnGrade = employeeVMChanges.ClassMnGrade;

                    _employeeRepository.UpdateEmployee(foundEmployee);
                }
            }


            return View();
        }
    }
}
