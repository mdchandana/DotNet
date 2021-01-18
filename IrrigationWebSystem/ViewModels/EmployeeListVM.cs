using IrrigationWebSystem.Models.DomainEntities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ViewModels
{
    public class EmployeeListVM
    {
        //public List<SelectListItem> EmployeePositions2 { get; set; }
        public int PositionId { get; set; }  //this just id for selectlist
        public SelectList EmployeePositions { get; set; }
        public IEnumerable<EmployeeVM> EmployeesVMs { get; set; }

    }
}
