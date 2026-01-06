using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPulse_Task_Manager.MODELS.DTO;
 

namespace TechPulse_Task_Manager.DATAACCESS.Interfaces
{
    public interface ITaskService
    {
        Task<ResponseDTO> RegisterTaskAsync(TaskRegistrationDTO register);
    }
}
