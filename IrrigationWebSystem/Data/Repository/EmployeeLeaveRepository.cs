using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class EmployeeLeaveRepository : IEmployeeLeaveRepository
    {
        private AppDbContext _appDbContext;

        public EmployeeLeaveRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddEmpLeave(EmployeeLeave employeeLeave)
        {
            _appDbContext.EmployeeLeaves.Add(employeeLeave);
            _appDbContext.SaveChanges();
        }

        public void DeleteEmpLeaveByEmployeeId(int employeeId)
        {
            var foundEmployee = _appDbContext.EmployeeLeaves.Find(employeeId);
            if(foundEmployee != null)
            {
                _appDbContext.EmployeeLeaves.Remove(foundEmployee);
                _appDbContext.SaveChanges();

            }
        }

        public List<EmployeeLeave> GetEmpLeavesByEmployeeId(int employeeId)
        {
            return _appDbContext.EmployeeLeaves.ToList();
        }
    }
}
