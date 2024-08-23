using MediatR;
using StudentServices.Domain.Entities;

namespace StudentServices.Application.UseCases.Students.Queries
{
    public record GetAllStudentsQuery : IRequest<List<Student>>;
}
