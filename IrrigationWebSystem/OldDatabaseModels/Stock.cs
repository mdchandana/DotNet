using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("Stock", Schema = "e-irrigation")]
    public partial class Stock
    {
        [Key]
        [Column("ST_Id")]
        public int StId { get; set; }
        [Column("Items_Id")]
        public int? ItemsId { get; set; }
        [Column("PCM_Id")]
        [StringLength(6)]
        public string PcmId { get; set; }
        [Column("IOM_id")]
        [StringLength(6)]
        public string IomId { get; set; }
        [Column("ST_QtyPurchased", TypeName = "decimal(13, 2)")]
        public decimal? StQtyPurchased { get; set; }
        [Column("ST_QtyPurchasedCost", TypeName = "decimal(13, 2)")]
        public decimal? StQtyPurchasedCost { get; set; }
        [Column("ST_QtyIssued", TypeName = "decimal(13, 2)")]
        public decimal? StQtyIssued { get; set; }
        [Column("ST_SBbook")]
        [StringLength(50)]
        public string StSbbook { get; set; }
        [Column("ST_SBpage")]
        [StringLength(50)]
        public string StSbpage { get; set; }
        [Column("ST_Flag")]
        [StringLength(50)]
        public string StFlag { get; set; }
        [Column("ST_UpdatedDate", TypeName = "datetime")]
        public DateTime? StUpdatedDate { get; set; }
    }
}
