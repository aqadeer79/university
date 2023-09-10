using System;
using StudentAPI.Models;

namespace StudentAPI.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student? GetStudentById(Guid id);
    }
}

