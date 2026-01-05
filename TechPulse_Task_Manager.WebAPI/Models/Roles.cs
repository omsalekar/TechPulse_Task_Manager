using System.ComponentModel.DataAnnotations;

namespace TechPulse_Task_Manager.WebAPI.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
}
