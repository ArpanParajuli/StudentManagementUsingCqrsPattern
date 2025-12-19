using MediatR;
using StudentManagement.Api.Dtos;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Application.Commands
{
    public record UpdateStudentCommand(Guid id , string name , string email , int age) : IRequest<Student> 
    {
    }
}
