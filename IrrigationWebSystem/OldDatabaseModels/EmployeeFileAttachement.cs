using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("Employee_FileAttachement", Schema = "e-irrigation")]
    public partial class EmployeeFileAttachement
    {
        [Key]
        [Column("EMFA_Id")]
        public int EmfaId { get; set; }
        [Column("EMP_Number")]
        [StringLength(20)]
        public string EmpNumber { get; set; }
        [Column("EMFA_AttachedFileName")]
        [StringLength(300)]
        public string EmfaAttachedFileName { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
