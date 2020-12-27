using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("WM_RainFall", Schema = "e-irrigation")]
    public partial class WmRainFall
    {
        [Key]
        [Column("WRF_RainFallId")]
        public int WrfRainFallId { get; set; }
        [Column("WRF_RainFallArea")]
        [StringLength(100)]
        public string WrfRainFallArea { get; set; }
        [Column("WRF_RainFallDate", TypeName = "datetime")]
        public DateTime? WrfRainFallDate { get; set; }
        [Column("WRF_RainFallAmount", TypeName = "decimal(13, 2)")]
        public decimal? WrfRainFallAmount { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
