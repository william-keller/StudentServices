using MediatR;

namespace StudentServices.Application.UseCases.Students.Commands.UpdateStudentName
{
    public record UpdateStudentNameCommand(Guid StudentId, string newName) : IRequest;
}
