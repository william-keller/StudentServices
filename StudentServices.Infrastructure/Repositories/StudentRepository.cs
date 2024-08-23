using Microsoft.EntityFrameworkCore;
using StudentServices.Domain.Entities;
using StudentServices.Domain.Interfaces.Repositories;
using StudentServices.Infrastructure.Data;

namespace StudentServices.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentsDbContext _context;

        public StudentRepository(StudentsDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Students.ToListAsync(cancellationToken);
        }
    }
}
