using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmWaterLevelCapacityMuruthawelaTank
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal WaterLevel { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public int capacity { get; set; }
    }
}
