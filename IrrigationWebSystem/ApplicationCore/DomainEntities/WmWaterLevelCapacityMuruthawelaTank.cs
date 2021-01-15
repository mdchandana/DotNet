using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ApplicationCore.DomainEntities
{
    public class WmWaterLevelCapacityMuruthawelaTank
    {

        public int Id { get; set; }        
        public decimal WaterLevel { get; set; }
        public int? apacity { get; set; }
    }
}
