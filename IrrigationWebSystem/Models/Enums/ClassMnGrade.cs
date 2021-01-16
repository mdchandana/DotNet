using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.Enums
{
    public enum ClassMnGrade
    {
        [Display(Name = "MN-1")]
        MN1 =1,
        [Display(Name = "MN-2")]
        MN2 =2,
        [Display(Name = "MN-3")]
        MN3 =3,
        [Display(Name = "MN-4")]
        MN4 = 4
    }
}
