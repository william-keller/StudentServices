using StudentServices.Domain.Entities;

namespace StudentServices.Domain.Interfaces.Repositories
{
    public interface IRepository
    {
        Task<List<Student>> GetAll(CancellationToken cancellationToken);
    }
}
