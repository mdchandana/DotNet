using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ApplicationCore.DomainEntities
{
    public class WmDailyWaterLevelAndissue
    {
        
        public int Id { get; set; }        
        public string TankName { get; set; }        
        public DateTime? WaterIssuingConsiderDate { get; set; }        
        public decimal? WarterLevelAtSluice { get; set; }        
        public decimal? EffectiveHead { get; set; }        
        public int? Capacity { get; set; }        
        public decimal? GateOpenedSize { get; set; }       
        public DateTime? WaterIssuedDurationFromDateWithTime { get; set; }       
        public DateTime? WaterIssuedDurationToDateWithTime { get; set; }       
        public decimal? NoOfHours { get; set; }       
        public decimal? WaterIssuedInAcft { get; set; }
       
    }
}
