using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JqueryAjax.Models.DomainEntities
{
    
    public class EmployeePosition
    {       
        public int Id { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string PositionCode { get; set; }


        public IEnumerable<EmployeePosition> GetAllPositions()
        {
            return new List<EmployeePosition>()
            {
                new EmployeePosition(){Id=1,Position="Irrigation Engineer",PositionCode="IE"},
                new EmployeePosition(){Id=2,Position="Development Officer",PositionCode="DO"},
                new EmployeePosition(){Id=3,Position="Engineer Assistant",PositionCode="EA"}
            };
        }


    }
}
