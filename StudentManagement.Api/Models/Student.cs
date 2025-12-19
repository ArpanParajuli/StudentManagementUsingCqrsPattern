using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Api.Models
{
    public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; }   = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; } = 0;

    }
}
