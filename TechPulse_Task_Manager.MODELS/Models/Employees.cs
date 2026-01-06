using System.ComponentModel.DataAnnotations;

namespace TechPulse_Task_Manager.WebAPI.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public bool IsWorkingOnProject { get; set; }
        public string Role { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
 

    }
}
