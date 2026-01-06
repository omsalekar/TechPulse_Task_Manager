using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechPulse_Task_Manager.MODELS.Models
{
    public class TaskScreenshots
    {
        [Key]
        public int ScreenshotId { get; set; }
        public int TaskId { get; set; }

        [ForeignKey(nameof(TaskId))]
        public Tasks? Task { get; set; }
        public string ScreenshotData { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; }
    }
}
