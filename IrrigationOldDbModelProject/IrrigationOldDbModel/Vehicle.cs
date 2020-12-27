using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("Vehicles", Schema = "e-irrigation")]
    public partial class Vehicle
    {
        [Key]
        [Column("Vehicle_Numbers")]
        [StringLength(100)]
        public string VehicleNumbers { get; set; }
    }
}
