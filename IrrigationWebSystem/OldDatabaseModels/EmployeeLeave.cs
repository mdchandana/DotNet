using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("Employee_Leave", Schema = "e-irrigation")]
    public partial class EmployeeLeave
    {
        [Key]
        [Column("EMPL_Id")]
        public int EmplId { get; set; }
        [Column("EMP_Number")]
        [StringLength(20)]
        public string EmpNumber { get; set; }
        [Column("EMPL_Type")]
        [StringLength(250)]
        public string EmplType { get; set; }
        [Column("EMPL_LeaveDate", TypeName = "datetime")]
        public DateTime? EmplLeaveDate { get; set; }
        [Column("EMPL_leaveFullOrHalfDay")]
        [StringLength(20)]
        public string EmplLeaveFullOrHalfDay { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
