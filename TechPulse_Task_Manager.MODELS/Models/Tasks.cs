using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechPulse_Task_Manager.WebAPI.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employees? Employee { get; set; } 
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public DateTime TaskDate { get; set; }
        public DateTime SubmittedAt { get; set; }
        public bool IsLocked { get; set; }
    }
}
