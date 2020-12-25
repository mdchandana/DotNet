using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("WM_WaterLevelCapacityMuruthawelaTank", Schema = "e-irrigation")]
    public partial class WmWaterLevelCapacityMuruthawelaTank
    {
        [Key]
        [Column("WLCM_Id")]
        public int WlcmId { get; set; }
        [Column("WLCM_WaterLevel", TypeName = "decimal(13, 1)")]
        public decimal WlcmWaterLevel { get; set; }
        [Column("WLCM_Capacity")]
        public int? WlcmCapacity { get; set; }
    }
}
