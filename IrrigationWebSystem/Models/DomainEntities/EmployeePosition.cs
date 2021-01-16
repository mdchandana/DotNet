using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IrrigationWebSystem.Models.DomainEntities
{
    
    public class EmployeePosition
    {       
        public int Id { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string PositionCode { get; set; }

        public List<Employee> Employees { get; set; }


    }
}
