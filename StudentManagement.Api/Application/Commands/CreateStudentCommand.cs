
using MediatR;

namespace StudentManagement.Api.Application.Commands
{
    public record CreateStudentCommand(string name , string email , int age) : IRequest<Guid>;
}
