using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IrrigationWebSystem.ApplicationCore.DomainEntities
{
    [Table("EmployeePosition")]
    public class EmployeePosition
    {       
        public int Id { get; set; }
        public string Position { get; set; }
        public string PositionCode { get; set; }

        public List<Employee> Employees { get; set; }


    }
}
