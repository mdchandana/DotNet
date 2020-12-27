using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationOldDbModelProject.IrrigationOldDbModel
{
    [Keyless]
    public partial class ViewAllEmployee
    {
        [Required]
        [Column("EMP_Number")]
        [StringLength(20)]
        public string EmpNumber { get; set; }
        [Column("EMP_PersonalFileNumber")]
        [StringLength(150)]
        public string EmpPersonalFileNumber { get; set; }
        [Column("EMP_Nic")]
        [StringLength(20)]
        public string EmpNic { get; set; }
        [Column("EMP_NameWithInitial")]
        [StringLength(200)]
        public string EmpNameWithInitial { get; set; }
        [Column("EMP_SurName")]
        [StringLength(200)]
        public string EmpSurName { get; set; }
        [Column("EMP_FullName")]
        [StringLength(200)]
        public string EmpFullName { get; set; }
        [Column("EMP_Address")]
        [StringLength(350)]
        public string EmpAddress { get; set; }
        [Column("EMP_DateOfBirth", TypeName = "datetime")]
        public DateTime? EmpDateOfBirth { get; set; }
        [Column("EMP_Gender")]
        [StringLength(50)]
        public string EmpGender { get; set; }
        [Column("EMP_CivilStatus")]
        [StringLength(50)]
        public string EmpCivilStatus { get; set; }
        [Column("EMP_AppointmentDate", TypeName = "datetime")]
        public DateTime? EmpAppointmentDate { get; set; }
        [Column("EMP_IncrementDay")]
        [StringLength(50)]
        public string EmpIncrementDay { get; set; }
        [Column("EMP_PensionDate", TypeName = "datetime")]
        public DateTime? EmpPensionDate { get; set; }
        [Column("EMP_Position")]
        [StringLength(100)]
        public string EmpPosition { get; set; }
        [Column("EMP_AchievedClass")]
        [StringLength(100)]
        public string EmpAchievedClass { get; set; }
        [Column("EMP_BasicSalary", TypeName = "decimal(13, 2)")]
        public decimal? EmpBasicSalary { get; set; }
        [Column("EMP_Contact1")]
        [StringLength(30)]
        public string EmpContact1 { get; set; }
        [Column("EMP_Contact2")]
        [StringLength(30)]
        public string EmpContact2 { get; set; }
        [Column("EMP_Email")]
        [StringLength(100)]
        public string EmpEmail { get; set; }
        [Column("EMP_FB")]
        [StringLength(100)]
        public string EmpFb { get; set; }
        [Column("EMP_Image")]
        public byte[] EmpImage { get; set; }
        [Column("EMP_Status")]
        [StringLength(50)]
        public string EmpStatus { get; set; }
        [Column("Updated_User")]
        [StringLength(150)]
        public string UpdatedUser { get; set; }
        [Column("Updated_date", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
