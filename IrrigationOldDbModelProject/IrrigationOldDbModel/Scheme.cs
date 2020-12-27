using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("Schemes", Schema = "e-irrigation")]
    public partial class Scheme
    {
        [Key]
        [Column("SC_Id")]
        [StringLength(5)]
        public string ScId { get; set; }
        [Column("SC_Name")]
        [StringLength(200)]
        public string ScName { get; set; }
    }
}
