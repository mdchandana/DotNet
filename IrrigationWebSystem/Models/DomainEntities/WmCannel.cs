using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmCannel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int SchemeId { get; set; }

        public int Track { get; set; }


        public WmScheme WmScheme { get; set; }
    }
}
