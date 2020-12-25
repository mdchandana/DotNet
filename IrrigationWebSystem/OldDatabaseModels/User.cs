using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace IrrigationWebSystem.OldDatabaseModels
{
    [Table("Users", Schema = "e-irrigation")]
    public partial class User
    {
        [Key]
        [Column("Users_Name")]
        [StringLength(150)]
        public string UsersName { get; set; }
        [Column("EMP_Number")]
        [StringLength(20)]
        public string EmpNumber { get; set; }
        [Column("Users_Type")]
        [StringLength(50)]
        public string UsersType { get; set; }
        [Column("Users_Password")]
        [StringLength(300)]
        public string UsersPassword { get; set; }
    }
}
