using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("ItemsMain", Schema = "e-irrigation")]
    public partial class ItemsMain
    {
        [Key]
        [Column("ItemsMain_Id")]
        public int ItemsMainId { get; set; }
        [Column("ItemsMain_Name")]
        [StringLength(250)]
        public string ItemsMainName { get; set; }
    }
}
