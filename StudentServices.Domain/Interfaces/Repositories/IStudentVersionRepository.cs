using StudentServices.Domain.Entities;

namespace StudentServices.Domain.Interfaces.Repositories
{
    public interface IStudentVersionRepository : IRepository
    {
        public Task MakeSnapshot(Student student);
        public Task<StudentVersion> GetSnapshot(Guid studentId, int version);
    }
}
