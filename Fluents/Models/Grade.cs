using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fluents.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [Required(ErrorMessage ="Grade Name required!")]
        public string GradeName { get; set; }
        [Required(ErrorMessage = "Section Name required!")]
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
