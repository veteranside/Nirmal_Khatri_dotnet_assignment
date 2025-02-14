using System.ComponentModel.DataAnnotations; // For data annotations

namespace Nirmal_Khatri_dotnet_assignment.Models
{
    public class jobinvestigate
    {
        [Key] // This marks the Id property as the primary key
        public int Id { get; set; } // Primary Key

        public string Name { get; set; }        // To store the name of the person
        public string Email { get; set; }       // To store the email address
        public string PhoneNumber { get; set; } // To store the phone number
        public string Post { get; set; }        // To store the job position
        public decimal Salary { get; set; }     // To store the salary (using decimal for currency)
    }
}

