using Fluents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fluents
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name required!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Current Grade Id required!")]
        public int GradeId { get; set; }

        public Grade Grade { get; set; }

    }
}
