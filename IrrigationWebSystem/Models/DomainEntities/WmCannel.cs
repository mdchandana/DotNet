using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.DomainEntities
{
    public class WmCannel
    {       

        [Required,Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CannelName { get; set; }

        [Required]
        public int WmSchemeId { get; set; }

        public string Track { get; set; }


        public WmScheme WmScheme { get; set; }
    }
}
