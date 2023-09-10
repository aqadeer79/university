using System;
using StudentAPI.Models;
using StudentAPI.Repositories;

namespace StudentAPI.Services.Impl
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = studentRepository.GetAllStudents();
            return students;
        }

        public Student? GetStudentById(Guid id)
        {
            Student? student = studentRepository.GetStudentById(id);
            return student;
        }
    }
}

