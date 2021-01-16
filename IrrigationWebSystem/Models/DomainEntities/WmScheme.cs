﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmScheme
    {        
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<WmCultivationSeasonInformation> WmCultivationSeasonInformations { get; set; }

    }
}
