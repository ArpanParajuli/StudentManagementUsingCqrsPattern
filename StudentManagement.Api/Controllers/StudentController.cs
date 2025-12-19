using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Application.Commands;
using StudentManagement.Api.Dtos;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IMediator _mediatR;
       
        public StudentController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateStudentDto student)
        {
            CreateStudentCommand command = new CreateStudentCommand(student.Name , student.Email , student.Age);
            var id = await _mediatR.Send(command);
            return Ok(id);
        }
    }
}
