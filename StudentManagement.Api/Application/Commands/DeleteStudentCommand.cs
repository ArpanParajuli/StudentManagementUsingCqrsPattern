using MediatR;

namespace StudentManagement.Api.Application.Commands
{
    public record DeleteStudentCommand(Guid Id) : IRequest<bool>;
}
