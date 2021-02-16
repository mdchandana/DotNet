using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmScheme
    {
        public int WmSchemeId { get; set; }
        public string Name { get; set; }

        public List<WmCultivationSeasonInformation> WmCultivationSeasonInformations { get; set; }
        public List<WmCannel> WmCannels { get; set; }
        
    }
}
