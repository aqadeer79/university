using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace crud_application_test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}

