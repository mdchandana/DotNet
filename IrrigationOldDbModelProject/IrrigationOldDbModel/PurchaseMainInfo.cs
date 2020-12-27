using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("PurchaseMainInfo", Schema = "e-irrigation")]
    public partial class PurchaseMainInfo
    {
        [Key]
        [Column("PCM_Id")]
        [StringLength(6)]
        public string PcmId { get; set; }
        [Column("BYS_Id")]
        public int? BysId { get; set; }
        [Column("PCM_BillNumber")]
        [StringLength(25)]
        public string PcmBillNumber { get; set; }
        [Column("PCM_BillDate", TypeName = "datetime")]
        public DateTime? PcmBillDate { get; set; }
        [Column("PCM_OrderNumber")]
        [StringLength(25)]
        public string PcmOrderNumber { get; set; }
        [Column("PCM_BillTotalCost", TypeName = "numeric(13, 2)")]
        public decimal? PcmBillTotalCost { get; set; }
        [Column("PCM_PaymentStatus")]
        [StringLength(25)]
        public string PcmPaymentStatus { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
