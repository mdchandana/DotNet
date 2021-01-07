using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyMash.Models
{    
    public class Make
    {
        public int Id { get; set; }

        [Required]        
        [Display(Name ="Make Name")]
        public string Name { get; set; }
    }
}