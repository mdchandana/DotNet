using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("ItemsSub", Schema = "e-irrigation")]
    public partial class ItemsSub
    {
        [Key]
        [Column("ItemSub_Id")]
        public int ItemSubId { get; set; }
        [Column("ItemsMain_Id")]
        public int? ItemsMainId { get; set; }
        [Column("ItemsSub_Name")]
        [StringLength(300)]
        public string ItemsSubName { get; set; }
    }
}
