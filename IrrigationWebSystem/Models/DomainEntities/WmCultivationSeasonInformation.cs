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
        public CultivationSeason CultivationSeason { get; set; }    //enums

        [Required]
        public int CultivationSeasonYear { get; set; }
               
        public int WmSchemeId { get; set; }   


        public DateTime? WaterIssueStartDate { get; set; }       
        public DateTime? WaterIssueEndDate { get; set; }



        public WmScheme WmScheme { get; set; }
    }
}
