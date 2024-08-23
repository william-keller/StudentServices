using Microsoft.EntityFrameworkCore;
using StudentServices.Domain.Entities;

namespace StudentServices.Infrastructure.Data
{
    public class StudentCoursesDbContext : DbContext
    {
        public DbSet<StudentCourses> StudentCourses { get; set; }

        public StudentCoursesDbContext(DbContextOptions<StudentCoursesDbContext> options) : base(options)
        {

        }
    }
}
