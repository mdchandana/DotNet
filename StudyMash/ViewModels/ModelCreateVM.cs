using StudyMash.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMash.ViewModels
{
    public class ModelCreateVM
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Model Name")]
        public string Name { get; set; }

        //public int MakeId { get; set; }
        public Make Make { get; set; }
    }
}
