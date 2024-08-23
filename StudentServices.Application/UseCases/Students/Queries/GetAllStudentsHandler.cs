using MediatR;
using StudentServices.Domain.Entities;
using StudentServices.Domain.Interfaces.Repositories;

namespace StudentServices.Application.UseCases.Students.Queries
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, List<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetAllStudentsHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetAll(cancellationToken);
        }
    }
}
