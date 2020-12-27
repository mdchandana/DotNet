using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("IssueOrders", Schema = "e-irrigation")]
    public partial class IssueOrder
    {
        [Key]
        [Column("IOM_id")]
        [StringLength(6)]
        public string IomId { get; set; }
        [Column("IOM_OrderNumber")]
        [StringLength(15)]
        public string IomOrderNumber { get; set; }
        [Column("IOM_IssuedTo")]
        [StringLength(150)]
        public string IomIssuedTo { get; set; }
        [Column("IOM_Date", TypeName = "datetime")]
        public DateTime? IomDate { get; set; }
        [Column("IOM_Idb")]
        [StringLength(200)]
        public string IomIdb { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
