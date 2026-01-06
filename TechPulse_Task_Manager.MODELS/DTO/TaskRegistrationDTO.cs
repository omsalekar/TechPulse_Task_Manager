using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPulse_Task_Manager.MODELS.DTO
{
    public class TaskRegistrationDTO
    {
        public int EmployeeId { get; set; }
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public DateTime TaskDate { get; set; }
    }
}
