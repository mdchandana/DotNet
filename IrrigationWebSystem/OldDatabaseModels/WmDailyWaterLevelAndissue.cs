using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("WM_DailyWaterLevelANDIssue", Schema = "e-irrigation")]
    public partial class WmDailyWaterLevelAndissue
    {
        [Key]
        [Column("DWL_Id")]
        public int DwlId { get; set; }
        [Column("DWL_TankName")]
        [StringLength(200)]
        public string DwlTankName { get; set; }
        [Column("DWL_WaterIssuingConsiderDate", TypeName = "datetime")]
        public DateTime? DwlWaterIssuingConsiderDate { get; set; }
        [Column("DWL_WarterLevelAtSluice", TypeName = "decimal(13, 2)")]
        public decimal? DwlWarterLevelAtSluice { get; set; }
        [Column("DWL_EffectiveHead", TypeName = "decimal(13, 2)")]
        public decimal? DwlEffectiveHead { get; set; }
        [Column("DWL_Capacity")]
        public int? DwlCapacity { get; set; }
        [Column("DWL_GateOpenedSize", TypeName = "decimal(13, 2)")]
        public decimal? DwlGateOpenedSize { get; set; }
        [Column("DWL_WaterIssuedDurationFromDateWithTime", TypeName = "datetime")]
        public DateTime? DwlWaterIssuedDurationFromDateWithTime { get; set; }
        [Column("DWL_WaterIssuedDurationToDateWithTime", TypeName = "datetime")]
        public DateTime? DwlWaterIssuedDurationToDateWithTime { get; set; }
        [Column("DWL_NoOfHours", TypeName = "decimal(13, 2)")]
        public decimal? DwlNoOfHours { get; set; }
        [Column("DWL_WaterIssuedInACFT", TypeName = "decimal(13, 2)")]
        public decimal? DwlWaterIssuedInAcft { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
