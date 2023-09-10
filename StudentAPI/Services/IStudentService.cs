using System;
using StudentAPI.Models;

namespace StudentAPI.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student? GetStudentById(Guid id);
    }
}

