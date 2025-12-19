namespace StudentManagement.Api.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }   = string.Empty;  

        public string Email { get; set; } = string.Empty;

        public int Age { get; set; } = 0;

    }
}
