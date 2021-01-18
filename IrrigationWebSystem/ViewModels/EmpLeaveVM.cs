using IrrigationWebSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ViewModels
{
    public class EmpLeaveVM
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        public LeaveType LeaveType { get; set; }   //enums

        [Required]
        public DateTime LeaveDate { get; set; }

        [Required]
        public HalfFullLeaveType HalfFullLeaveType { get; set; }   //enums


        //    public Employee Employee { get; set; }
    }
}
