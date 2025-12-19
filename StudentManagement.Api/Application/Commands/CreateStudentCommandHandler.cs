
using MediatR;
using StudentManagement.Api.Data;
using StudentManagement.Api.Models;

namespace StudentManagement.Api.Application.Commands
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Guid>
    {
        private readonly AppDbContext _context;
        public CreateStudentCommandHandler(AppDbContext context) 
        { 
          _context = context;
        }

        public async Task<Guid> Handle(CreateStudentCommand command , CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Pid = Guid.NewGuid(),
                Name = command.name,
                Email = command.email,
                Age = command.age
            };


            await _context.Students.AddAsync(student);

            await _context.SaveChangesAsync(cancellationToken);

            return student.Pid;
        }
    }
}
