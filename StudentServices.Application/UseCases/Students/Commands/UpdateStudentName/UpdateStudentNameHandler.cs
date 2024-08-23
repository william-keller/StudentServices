using MediatR;

namespace StudentServices.Application.UseCases.Students.Commands.UpdateStudentName
{
    public class UpdateStudentNameHandler : IRequestHandler<UpdateStudentNameCommand>
    {

        public async Task Handle(UpdateStudentNameCommand request, CancellationToken cancellationToken)
        {
            
        }
    }
}
