using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationWebSystem.Models.Enums;

namespace IrrigationWebSystem.Models.DomainEntities
{
   
    public class EmployeeLeave
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public int EmployeeId { get; set; }

        [Required]
        public LeaveType LeaveType { get; set; }   //enums

        [Required]
        public DateTime LeaveDate { get; set; }

        [Required]
        public HalfFullLeaveType HalfFullLeaveType { get; set; }   //enums


        public Employee Employee { get; set; }


    }
}
