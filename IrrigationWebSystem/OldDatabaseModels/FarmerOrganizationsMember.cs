using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("FarmerOrganizationsMembers", Schema = "e-irrigation")]
    public partial class FarmerOrganizationsMember
    {
        [Key]
        [Column("FOM_Id")]
        public int FomId { get; set; }
        [Column("FO_Id")]
        public int FoId { get; set; }
        [Column("FOM_MemberName")]
        [StringLength(200)]
        public string FomMemberName { get; set; }
        [Column("FOP_Positions")]
        [StringLength(200)]
        public string FopPositions { get; set; }
        [Column("FOM_MemberAddress")]
        [StringLength(200)]
        public string FomMemberAddress { get; set; }
        [Column("FOM_MemberContact1")]
        [StringLength(20)]
        public string FomMemberContact1 { get; set; }
        [Column("FOM_MemberContact2")]
        [StringLength(20)]
        public string FomMemberContact2 { get; set; }
        [Column("FOM_RelevantYear")]
        [StringLength(10)]
        public string FomRelevantYear { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
