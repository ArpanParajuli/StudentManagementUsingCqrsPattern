using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Api.Data;
using StudentManagement.Api.Dtos;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Application.Commands
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand , Student>
    {

        private readonly AppDbContext _appDbContext;
        public UpdateStudentCommandHandler(AppDbContext appDbContext) 
        {
          _appDbContext = appDbContext;
        }

        public async Task<Student> Handle(UpdateStudentCommand command , CancellationToken cancellationToken)
        {
            var student = await _appDbContext.Students.FirstOrDefaultAsync(s => s.Pid == command.id);
            student.Name = command.name;
            student.Age = command.age;
            student.Email = command.email;

            await _appDbContext.SaveChangesAsync(cancellationToken);

            return student;
            
        }
    }
}
