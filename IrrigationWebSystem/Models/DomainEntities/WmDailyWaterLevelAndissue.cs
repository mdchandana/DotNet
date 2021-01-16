using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmDailyWaterLevelAndissue
    {
        
        public int Id { get; set; }

        [Required]
        public string TankName { get; set; }

        [Required]
        public DateTime? WaterIssuingConsiderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal WarterLevelAtSluice { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? EffectiveHead { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal GateOpenedSize { get; set; }

        [Required]
        public DateTime? WaterIssuedDurationFromDateWithTime { get; set; }

        [Required]
        public DateTime? WaterIssuedDurationToDateWithTime { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NoOfHours { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal WaterIssuedInAcft { get; set; }
       
    }
}
