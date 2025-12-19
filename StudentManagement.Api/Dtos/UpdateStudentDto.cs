using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Api.Dtos
{
    public record UpdateStudentDto
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; } = string.Empty;


        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(1, 150)]
        public int Age { get; set; }
    }
}
