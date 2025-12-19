using MediatR;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Application.Queries
{
    public record GetStudentByIdQuery(Guid Id) : IRequest<Student?>;
}
