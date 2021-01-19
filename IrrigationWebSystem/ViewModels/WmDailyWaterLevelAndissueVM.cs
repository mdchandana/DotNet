using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ViewModels
{
    public class WmDailyWaterLevelAndissueVM
    {
        public int Id { get; set; }

        [Required]
        public string TankName { get; set; }

        [Required]
       
        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime WaterIssuingConsiderDate { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal WarterLevelAtSluice { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal EffectiveHead { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal GateOpenedSize { get; set; }

        [Required]      
        public DateTime WaterIssuedDurationFromDateWithTime { get; set; }

        [Required]
        public DateTime WaterIssuedDurationToDateWithTime { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal NoOfHours { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal WaterIssuedInAcft { get; set; }
    }
}
