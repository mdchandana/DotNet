using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VenkatCore.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }       

        [Required]
        public string Name { get; set; }        
        public string Email { get; set; }      
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
        public int DeptId { get; set; }

        [ForeignKey("DeptId")]
        public virtual Department Department { get; set; }   //employee belongs to a single department ... cardinality '1'
    }
}
