using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IrrigationWebSystem.Models.DomainEntities
{
    [Table("EmployeeLeave")]
    public class EmployeeLeave
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime LeaveDate { get; set; }

        [Required]
        public string leaveFullOrHalfDay { get; set; }


        public Employee Employee { get; set; }


    }
}
