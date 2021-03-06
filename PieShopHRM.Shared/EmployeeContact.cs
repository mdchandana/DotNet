﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopHRM.Shared
{
    [Table("EmployeeContact")]
    public class EmployeeContact
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Contact { get; set; }

        public Employee Employee { get; set; }
    }
}
