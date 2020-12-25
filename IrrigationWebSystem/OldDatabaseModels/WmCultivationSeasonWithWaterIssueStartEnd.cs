using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("WM_CultivationSeasonWithWaterIssueStartEnd", Schema = "e-irrigation")]
    public partial class WmCultivationSeasonWithWaterIssueStartEnd
    {
        [Key]
        [Column("WMCS_CultivationSeasonIdId")]
        public int WmcsCultivationSeasonIdId { get; set; }
        [Column("WMCS_CultivationSeason")]
        [StringLength(200)]
        public string WmcsCultivationSeason { get; set; }
        [Column("WMCS_Scheme")]
        [StringLength(100)]
        public string WmcsScheme { get; set; }
        [Column("WMCS_WaterIssueStartDate", TypeName = "datetime")]
        public DateTime? WmcsWaterIssueStartDate { get; set; }
        [Column("WMCS_WaterIssueEndDate", TypeName = "datetime")]
        public DateTime? WmcsWaterIssueEndDate { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
