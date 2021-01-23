using IrrigationWebSystem.Models.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.Interfaces
{
    public interface IEmployeeLeaveRepository
    {
        List<EmployeeLeave> GetEmpLeavesByEmployeeId(int employeeId);
        void AddEmpLeave(List<EmployeeLeave> employeeLeaveList);
        void DeleteEmpLeaveByEmployeeId(int employeeId);

    }
}
