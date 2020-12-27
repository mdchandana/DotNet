using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("Buyers", Schema = "e-irrigation")]
    public partial class Buyer
    {
        [Key]
        [Column("BYS_Id")]
        public int BysId { get; set; }
        [Column("BYS_Name")]
        [StringLength(250)]
        public string BysName { get; set; }
        [Column("BYS_Address")]
        [StringLength(300)]
        public string BysAddress { get; set; }
    }
}
