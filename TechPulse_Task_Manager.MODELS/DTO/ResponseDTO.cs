using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPulse_Task_Manager.WebAPI.Models;

namespace TechPulse_Task_Manager.MODELS.DTO
{
    public class ResponseDTO
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public bool IsWorkingOnProject { get; set; }
        public DateTime CreatedAt { get; set; }
      
    }
}
