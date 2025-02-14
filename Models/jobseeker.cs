using System.ComponentModel.DataAnnotations;

namespace Nirmal_Khatri_dotnet_assignment.Models
{
    public class JobSeeker
    {
        [Key] // Marks Id as the primary key
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [StringLength(200)]
        public string ApplicationLink { get; set; }
    }
}
