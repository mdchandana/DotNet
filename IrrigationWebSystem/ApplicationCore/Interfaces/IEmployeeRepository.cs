using IrrigationWebSystem.ApplicationCore.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ApplicationCore.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
    }
}
