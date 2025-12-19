using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Application.Commands;
using StudentManagement.Api.Application.Queries;
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


        [HttpGet("/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var student = await _mediatR.Send(new GetStudentByIdQuery(id));
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStudentDto student)
        {
            CreateStudentCommand command = new CreateStudentCommand(student.Name , student.Email , student.Age);
            var id = await _mediatR.Send(command);
            return Ok(id);
        }

        [HttpPut("/{id}")]

        public async Task<IActionResult> Update(Guid id , UpdateStudentDto student)
        {
            UpdateStudentCommand command = new UpdateStudentCommand(id , student.Name , student.Email , student.Age);   

            var updatedstudent = await _mediatR.Send(command);

            return Ok(updatedstudent);
        }

        [HttpDelete("/{id}")]

        public async Task<IActionResult> Delete(Guid id)
        {
            DeleteStudentCommand command = new DeleteStudentCommand(id);

            var IsSuccess = await _mediatR.Send(command);

            return Ok(IsSuccess);

        }
    }
}
