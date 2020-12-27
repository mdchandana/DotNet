using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("Employee_Positions", Schema = "e-irrigation")]
    public partial class EmployeePosition
    {
        [Key]
        [Column("EMPP_Id")]
        [StringLength(5)]
        public string EmppId { get; set; }
        [Column("EMPP_Position")]
        [StringLength(100)]
        public string EmppPosition { get; set; }
        [Column("EMPP_PositionCode")]
        [StringLength(20)]
        public string EmppPositionCode { get; set; }
    }
}
