using Microsoft.EntityFrameworkCore;
using StudentManagement.Api.Data;
using MediatR;

namespace StudentManagement.Api.Application.Commands
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand , bool>
    {
        private readonly AppDbContext _context;
        public DeleteStudentCommandHandler(AppDbContext context) 
        { 
          _context = context;
        }


        public async Task<bool> Handle(DeleteStudentCommand command , CancellationToken cancellationToken)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Pid == command.Id);

            if (student != null)
            { 
                student.IsDeleted = true; // soft delete
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }

            return false;
        }
    }
}
