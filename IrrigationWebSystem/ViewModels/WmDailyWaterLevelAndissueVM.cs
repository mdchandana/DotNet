using Microsoft.AspNetCore.Mvc;
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

        //IsWaterlevelCorrect

        [Required(ErrorMessage = "Waterlevel at sluice field is required.")]
        //[Column(TypeName = "decimal(13,2)")]
        //[Remote(controller: "WaterIssue", action: "IsWaterlevelCorrect", ErrorMessage = "The Waterlevel you entered, not a valid level")]  ///WORKED
        public decimal WarterLevelAtSluice { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal EffectiveHead { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "GateOpenedSize field is required.")]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal GateOpenedSize { get; set; }

        [Required(ErrorMessage = "WaterIssue Start Date/Time field is required.")]
        public DateTime WaterIssuedDurationFromDateWithTime { get; set; }

        [Required(ErrorMessage = "WaterIssue End Date/Time field is required.")]
        public DateTime WaterIssuedDurationToDateWithTime { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal NoOfHours { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal WaterIssuedInAcft { get; set; }
    }
}
