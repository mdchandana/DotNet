using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Table("FarmerOrganizationPosiitons", Schema = "e-irrigation")]
    public partial class FarmerOrganizationPosiiton
    {
        [Key]
        [Column("FOP_Positions")]
        [StringLength(100)]
        public string FopPositions { get; set; }
    }
}
