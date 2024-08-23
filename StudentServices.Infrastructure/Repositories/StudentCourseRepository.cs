using StudentServices.Domain.Entities;
using StudentServices.Domain.Interfaces.Repositories;

namespace StudentServices.Infrastructure.Repositories
{
    public class StudentCourseRepository : IStudentCourseRepository
    {
        public Task<List<Student>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task AssignStudentToCourse(Guid studentId, Guid courseId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
