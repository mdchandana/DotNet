using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Models
{

    //The ability to exclude tables from migrations was introduced in EF Core 5.0.

    [NotMapped]  //If you don't want a type to be included in the model, you can exclude it:
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    
}
