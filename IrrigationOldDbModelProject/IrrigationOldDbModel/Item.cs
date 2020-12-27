using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("Items", Schema = "e-irrigation")]
    public partial class Item
    {
        [Key]
        [Column("Items_Id")]
        public int ItemsId { get; set; }
        [Column("ItemsMain_Id")]
        public int? ItemsMainId { get; set; }
        [Column("ItemSub_Id")]
        public int? ItemSubId { get; set; }
        [Column("Items_Name")]
        [StringLength(300)]
        public string ItemsName { get; set; }
        [Column("Items_Page")]
        [StringLength(25)]
        public string ItemsPage { get; set; }
        [Column("Items_Count", TypeName = "decimal(13, 2)")]
        public decimal? ItemsCount { get; set; }
        [Column("Items_CountType")]
        [StringLength(50)]
        public string ItemsCountType { get; set; }
    }
}
