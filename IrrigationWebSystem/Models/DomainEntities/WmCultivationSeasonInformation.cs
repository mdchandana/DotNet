using IrrigationWebSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmCultivationSeasonInformation
    {        
        public int Id { get; set; }

        [Required]
        public int WmSchemeId { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public CultivationYalaMaha CultivationYalaMaha { get; set; }    //enums             

        [Required]
        public DateTime WaterIssueStartDate { get; set; }

        [Required]
        public DateTime WaterIssueEndDate { get; set; }

        public string Status { get; set; }




        public WmScheme WmScheme { get; set; }
    }
}
