using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ViewModels
{
    public class WmCannelsWaterIssu
    {
        public int Id { get; set; }        

        public string CanelName { get; set; }

        [Required(ErrorMessage = "WaterIssue Start Date/Time field is required.")]
        public DateTime WaterIssuedDurationFromDateWithTime { get; set; }

        [Required(ErrorMessage = "WaterIssue End Date/Time field is required.")]
        public DateTime WaterIssuedDurationToDateWithTime { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal WaterIssuedInCumecs { get; set; }

        [Required]
        //[Column(TypeName = "decimal(13,2)")]
        public decimal WaterIssuedInAcft { get; set; }

    }
}
