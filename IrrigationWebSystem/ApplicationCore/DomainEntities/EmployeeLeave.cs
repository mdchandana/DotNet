using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IrrigationWebSystem.ApplicationCore.DomainEntities
{
    [Table("EmployeeLeave")]
    public class EmployeeLeave
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Type { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string leaveFullOrHalfDay { get; set; }

        public Employee Employee { get; set; }


    }
}
