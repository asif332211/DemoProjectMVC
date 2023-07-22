using System.ComponentModel.DataAnnotations;

namespace DemoProjectMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]  
        public string Email { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; } = string.Empty;
    }
}
