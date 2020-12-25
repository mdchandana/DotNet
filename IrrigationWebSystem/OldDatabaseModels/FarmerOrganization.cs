using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("FarmerOrganizations", Schema = "e-irrigation")]
    public partial class FarmerOrganization
    {
        [Key]
        [Column("FO_Id")]
        public int FoId { get; set; }
        [Required]
        [Column("SC_Id")]
        [StringLength(5)]
        public string ScId { get; set; }
        [Column("FO_OrgName")]
        [StringLength(200)]
        public string FoOrgName { get; set; }
        [Column("FO_RegisteredNo")]
        [StringLength(200)]
        public string FoRegisteredNo { get; set; }
        [Column("FO_RegisteredDate", TypeName = "datetime")]
        public DateTime? FoRegisteredDate { get; set; }
        [Column("FO_TotalMembers")]
        public int? FoTotalMembers { get; set; }
        [Column("FO_RelevantYear")]
        [StringLength(10)]
        public string FoRelevantYear { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
