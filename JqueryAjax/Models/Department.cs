using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Models.DomainEntities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Department> GetDepartment()
        {
            return new List<Department>()
            {
                new Department(){Id=1,Name="It"},
                new Department(){Id=2,Name="Hr"},
                new Department(){Id=3,Name="Accounting"}
            };
        }


    }
}
