using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.ViewModels
{
    public class CascadeListVM
    {
        public int PositionId { get; set; }
        public SelectList EmpPositionsSelectList { get; set; }



        public int EmpNumber { get; set; }
        public SelectList EmpNamesSelectList { get; set; }
    }
}
