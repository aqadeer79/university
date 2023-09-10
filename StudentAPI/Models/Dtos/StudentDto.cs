using System;
namespace StudentAPI.Models
{
    public class StudentDto
    {
        public StudentDto(string Name, int Age, string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        private Guid Id { get; set; }
        private string Name { get; set; }
        private int Age { get; set; }
        private string Gender { get; set; }
    }
}

