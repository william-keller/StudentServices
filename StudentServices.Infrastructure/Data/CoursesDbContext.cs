﻿using Microsoft.EntityFrameworkCore;
using StudentServices.Domain.Entities;

namespace StudentServices.Infrastructure.Data
{
    public class CoursesDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public CoursesDbContext(DbContextOptions<CoursesDbContext> options) : base(options)
        {

        }
    }
}
