namespace TechPulse_Task_Manager.WebAPI.DTO
{
    public class RegistrationDTO
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public bool IsWorkingOnProject { get; set; }
        public string Role { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
