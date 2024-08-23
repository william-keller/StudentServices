using Microsoft.EntityFrameworkCore;
using StudentServices.Domain.Entities;

namespace StudentServices.Infrastructure.Data
{
    public class StudentsDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options)
        {

        }
    }
}
