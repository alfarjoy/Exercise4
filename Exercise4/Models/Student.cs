using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise4.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name is mandatory!")]
        public string Name { get; set; }

        [Required, Range(16, 99)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Name is mandatory!"), StringLength(200)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Name is mandatory!")]
        public string Course { get; set; }

        [Required, Range(1, 5)]
        public int YearLevel { get; set; }
    }
}
