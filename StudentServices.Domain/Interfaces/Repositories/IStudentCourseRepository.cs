namespace StudentServices.Domain.Interfaces.Repositories
{
    public interface IStudentCourseRepository : IRepository
    {
        Task AssignStudentToCourse(Guid studentId, Guid courseId, CancellationToken cancellationToken);
    }
}
