using StudentManagement.Api.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Test
{
    public class StudentCreateTest
    {

        CreateStudentCommand CreateStudentCommand;
        public StudentCreateTest() {
            CreateStudentCommand = new CreateStudentCommand("Arpan Parajuli" , "arpanparajuli07@gmail.com" , 20);
        }

        [Fact]
        public void CreateStudentTestMethod()
        {
         
            
        }
    }
}
