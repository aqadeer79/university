using System;
using crud_application_test.Data;
using StudentAPI.Models;

namespace StudentAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Student> GetAllStudents()
        {
            return dbContext.Students.ToList();
        }

        public Student? GetStudentById(Guid id)
        {
            return dbContext.Students.FirstOrDefault(x => x.Id == id);
        }
    }
}

