using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ViewModels
{
    public class WmWaterIssuesForPeriodVM
    {
        
        [DataType(DataType.Date)]       
        public DateTime DurationStart { get; set; }

        [DataType(DataType.Date)]
        public DateTime DurationEnd { get; set; }
    }
}
