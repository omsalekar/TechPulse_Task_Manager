using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechPulse_Task_Manager.WebAPI.Models
{
    public class TaskCounts
    {
        [Key]
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employees Employee { get; set; }
        public int TotalTasks { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
