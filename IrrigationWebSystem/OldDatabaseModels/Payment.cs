using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("Payments", Schema = "e-irrigation")]
    public partial class Payment
    {
        [Key]
        [Column("PM_Id")]
        public int PmId { get; set; }
        [Required]
        [Column("PCM_Id")]
        [StringLength(6)]
        public string PcmId { get; set; }
        [Column("PM_PaymentMethod")]
        [StringLength(20)]
        public string PmPaymentMethod { get; set; }
        [Column("PM_ChequeNumber")]
        [StringLength(20)]
        public string PmChequeNumber { get; set; }
        [Column("PM_PaidAmount", TypeName = "decimal(13, 2)")]
        public decimal? PmPaidAmount { get; set; }
        [Column("PM_PaidDate", TypeName = "datetime")]
        public DateTime? PmPaidDate { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
