using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmRainFall
    {   
        public int Id { get; set; }

        [Required]
        public string RainFallArea { get; set; }

        [Required]
        public DateTime RainFallDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(13,2)")]
        public decimal RainFallAmount { get; set; }       
    }
}
