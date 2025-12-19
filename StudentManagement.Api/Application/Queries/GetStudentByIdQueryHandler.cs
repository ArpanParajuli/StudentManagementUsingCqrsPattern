using Microsoft.EntityFrameworkCore;
using StudentManagement.Api.Data;
using StudentManagement.Api.Models;
using MediatR;

namespace StudentManagement.Api.Application.Queries
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery , Student?>
    {
        private readonly AppDbContext _context;
        public GetStudentByIdQueryHandler(AppDbContext appDbContext) 
        {
            _context = appDbContext;
        }



        public async Task<Student?> Handle(GetStudentByIdQuery command , CancellationToken cancellationToken)
        {
            return await _context.Students
                .AsNoTracking() // disables ef core tracking for performance
                .FirstOrDefaultAsync(s => s.Pid == command.Id, cancellationToken);

        }
    }
}
