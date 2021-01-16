using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmCultivationSeasonInformations
    {        
        public int Id { get; set; }

        //[Required]
        public string CultivationSeason { get; set; }

        //[Required]
        public string CultivationSeasonYear { get; set; }

        //[Required]
        public string Scheme { get; set; }   
        
        public DateTime? WaterIssueStartDate { get; set; }       
        public DateTime? WaterIssueEndDate { get; set; }       
    }
}
