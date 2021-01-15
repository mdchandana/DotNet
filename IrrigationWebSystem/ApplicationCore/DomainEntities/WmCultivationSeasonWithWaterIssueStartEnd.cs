using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ApplicationCore.DomainEntities
{
    public class WmCultivationSeasonInformations
    {        
        public int Id { get; set; }        
        public string CultivationSeason { get; set; }
        public string CultivationSeasonYear { get; set; }
        public string Scheme { get; set; }       
        public DateTime? WaterIssueStartDate { get; set; }       
        public DateTime? WaterIssueEndDate { get; set; }       
    }
}
