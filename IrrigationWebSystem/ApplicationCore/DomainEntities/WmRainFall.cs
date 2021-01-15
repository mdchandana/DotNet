using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ApplicationCore.DomainEntities
{
    public class WmRainFall
    {   
        public int RainFallId { get; set; }       
        public string RainFallArea { get; set; }        
        public DateTime? RainFallDate { get; set; }        
        public decimal? RainFallAmount { get; set; }       
    }
}
