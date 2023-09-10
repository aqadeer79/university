using System;
using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    public class Student
    {
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int? Age { get; set; }

        [Required]
        public string? Gender { get; set; }
    }
}

