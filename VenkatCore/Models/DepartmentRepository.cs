using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenkatCore.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

       

        public IEnumerable<Department> GetDepartments()
        {
            return _appDbContext.Departments;

            //var deptList = _appDbContext.Departments.ToList();
            //deptList.Insert(0, new Department() { Id = 0, DeptName = "Select" });

            //return deptList
        }

      
    }
}
