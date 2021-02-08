using IrrigationWebSystem.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ViewModels
{
    public class EmployeeLeaveVM
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public string NameWithInitial { get; set; }

        [Required]
        public LeaveType LeaveType { get; set; }   //enums

        [Required]
        [DataType(DataType.Date)]
        public DateTime LeaveDate { get; set; }

        [Required]
        public HalfFullLeaveType HalfFullLeaveType { get; set; }   //enums


        //public Employee Employee { get; set; }




        public int PositionId { get; set; }  //this just id for selectlist
        public SelectList EmployeePositions { get; set; }



                
        public SelectList Employees { get; set; }



        public int IdForLeaveTempList { get; set; }


    }
}
