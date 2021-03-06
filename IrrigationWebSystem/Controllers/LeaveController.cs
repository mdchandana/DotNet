﻿using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using IrrigationWebSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace IrrigationWebSystem.Controllers
{
    public class LeaveController : Controller
    {
        private IEmployeeLeaveRepository _employeeLeaveRepository;
        private IEmployeeRepository _employeeRepository;
        private IPositionRepository _positionRepository;
        private List<EmployeeLeaveVM> _leaveTempList;

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


        //[HttpGet]
        //public IActionResult GetEmployeesByPosition(int positionId)
        //{
        //    var employees = _employeeRepository.GetEmployeesByPositionId(positionId);

        //    var nameList = new List<string>()
        //    {
        //        new string("chandana"),
        //        new string("priyantha")
        //    };


        //    return Json(employees.ToList());
        //}


        //--------This is for cascadedropdownlist---------------------------------------------
        [HttpGet]
        public JsonResult GetEmployeesByPositionId(int PositionId)
        {

            List<EmployeeVM> employeesByPosition = _employeeRepository
                                            .GetEmployeesByPositionId(PositionId)
                                            .Select(emp => new EmployeeVM()
                                            {
                                                EmployeeId=emp.EmployeeId,
                                                NameWithInitial=emp.NameWithInitial
                                            }).ToList();


            //var empSelectlist = new SelectList(employeesByPosition, "EmpNumber", "NameWithInitial");

            //return Json(new SelectList(employeesByPosition, "EmpNumber", "NameWithInitial"));

            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = null
            };

            return Json(employeesByPosition, options);
        }













        [HttpGet]
        public ActionResult Create()
        {

            var employeeLeaveVM = new EmployeeLeaveVM()
            {
                EmployeePositions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position"),
                Employees = new SelectList(_employeeRepository.GetEmployees(), "EmployeeId", "NameWithInitial"),
                LeaveDate=DateTime.Today
            };



            return View(employeeLeaveVM);
        }

        [HttpPost]
        public ActionResult AddToListLeave(EmployeeLeaveVM empLeaveVM)
        {
            //==========NEED SOLUTION==== NOW TEMP
            //we need to pass NameWithInitials also....add NameWithInitial to EmployeeLeaveVM to viewing purpose..
            //with empLeave info.. so we have to get it
            var foundEmp = _employeeRepository.GetEmployeeByEmpId(empLeaveVM.EmployeeId);
            empLeaveVM.NameWithInitial = foundEmp.NameWithInitial;


            //using Microsoft.AspNetCore.Http;
            //HttpContext.Session.SetString("name", "chandana");
            //var nameFromSeesion = HttpContext.Session.GetString("name");
            if (ModelState.IsValid)
            {              

                //keeping empLeaveList in the session
                //And pass that tempList to view as a partial
                _leaveTempList = HttpContext.Session.GetLeaveTempListFromSession();

                //id for tempList                
                //so we can remove item from the temp list is easy..  
                //if we don't do if checking, max method return error saying no element il list
                if (_leaveTempList.Count == 0)
                    empLeaveVM.IdForLeaveTempList = 1;
                else
                    empLeaveVM.IdForLeaveTempList = _leaveTempList.Max(leave => leave.IdForLeaveTempList) + 1;

                _leaveTempList.Add(empLeaveVM);
                HttpContext.Session.SaveLeaveTempListToSession(_leaveTempList);
                return PartialView("PartialLeaveTempList", _leaveTempList);
            }
            return View(empLeaveVM);
        }

        [HttpGet]
        public ActionResult RemoveFromLeaveTempList(int tempId)
        {
            _leaveTempList = HttpContext.Session.GetLeaveTempListFromSession();
            var foundItem=_leaveTempList.Find(temp => temp.IdForLeaveTempList == tempId);
            _leaveTempList.Remove(foundItem);
            HttpContext.Session.SaveLeaveTempListToSession(_leaveTempList);
            return PartialView("PartialLeaveTempList", _leaveTempList);
        }





        [HttpGet]
        public ActionResult Update()
        {
            _leaveTempList = HttpContext.Session.GetLeaveTempListFromSession();
            //if (_leaveTempList.Count > 0)
            //{
                //mapping EmployeeLeaveVM to EmployeeLeave
                var employeeLeaveList = _leaveTempList.Select(empLeaveVM => new EmployeeLeave()
                {
                    EmployeeId = empLeaveVM.EmployeeId,
                    LeaveType = empLeaveVM.LeaveType,
                    HalfFullLeaveType = empLeaveVM.HalfFullLeaveType,
                    LeaveDate = empLeaveVM.LeaveDate  //empLeaveVM.LeaveDate.Value
                }).ToList();

                _employeeLeaveRepository.AddEmpLeave(employeeLeaveList);

                //clear the tempListSession
                _leaveTempList = new List<EmployeeLeaveVM>(); ;
                HttpContext.Session.Remove("leaveTempList");

            //}
            //else
            //{
                
            //    return Json( new {status = "EmptyList" });
            //}

            return PartialView("PartialLeaveTempList", _leaveTempList);
        }



        [HttpGet]
        public ActionResult SearchEmployeeLeaves()
        {
            var employeeLeaveVM = new EmployeeLeaveVM()
            {
                EmployeePositions = new SelectList(_positionRepository.GetAllPositions(), "Id", "Position"),
                Employees = new SelectList(_employeeRepository.GetEmployees(), "EmployeeId", "NameWithInitial")                
            };

            return View(employeeLeaveVM);
        }


        [HttpGet]
        public ActionResult SearchEmployeeLeavesByEmployeeId(int EmployeeId)
        {
            //==========NEED SOLUTION==== NOW TEMP
            //we need to pass NameWithInitials also....add NameWithInitial to EmployeeLeaveVM to viewing purpose..
            //with empLeave info.. so we have to get it
            var empNameWithInitial = _employeeRepository.GetEmployeeByEmpId(EmployeeId).NameWithInitial;


            var empLeaves = _employeeLeaveRepository.GetEmpLeavesByEmployeeId(EmployeeId)
                                .Select(empLeave => new EmployeeLeaveVM()
                                {
                                    EmployeeId= empLeave.EmployeeId,
                                    NameWithInitial= empNameWithInitial,
                                    LeaveType = empLeave.LeaveType,
                                    HalfFullLeaveType = empLeave.HalfFullLeaveType,
                                    LeaveDate = empLeave.LeaveDate

                                }).ToList();

            

            return PartialView("PartialSearchEmpLeave", empLeaves);
        }








        public void ClearTempList()
        {

        }


    }
}


//----------Remove specific key from ession
//public IActionResult Logout()
//{
//    HttpContext.Session.Remove("userObject");
//    return View();
//}



//--------Remove all session keys from session
//public IActionResult Logout()
//{
//    HttpContext.Session.Clear();
//    HttpContext.SignOutAsync();
//    return View();
//}