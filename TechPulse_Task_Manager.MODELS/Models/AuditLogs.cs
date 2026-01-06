using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechPulse_Task_Manager.MODELS.Models
{
    public class AuditLogs
    {
        [Key]
        public int LogId { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employees? Employee { get; set; }
        public string Action { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string Remarks { get; set; } = string.Empty;
    }
}
