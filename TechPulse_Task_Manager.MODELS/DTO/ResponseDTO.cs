

namespace TechPulse_Task_Manager.MODELS.DTO
{
    public class ResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public int RowsAffected { get; set; }

    }
}
