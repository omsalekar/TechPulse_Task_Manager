using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPulse_Task_Manager.DATAACCESS.Interfaces;
using TechPulse_Task_Manager.MODELS.DTO;
using Microsoft.Data.SqlClient;
using TechPulse_Task_Manager.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace TechPulse_Task_Manager.DATAACCESS.Repositories
{
    public class TaskService : ITaskService
    {
        private readonly TaskDbContext _db;
        public TaskService(TaskDbContext db)
        {
            _db = db;
        }
        public async Task<ResponseDTO> RegisterTaskAsync(TaskRegistrationDTO register)
        {
            var parameter = new List<SqlParameter>();
            {
                new SqlParameter("@EmployeeId", register.EmployeeId);
                new SqlParameter("@TaskTitle", register.TaskTitle);
                new SqlParameter("@TaskDescription", register.TaskDescription);
                new SqlParameter("@TaskDate", register.TaskDate); 
            }

           var query = "EXECUTE sp_RegisterTask @EmployeeId, @TaskTitle, @TaskDescription, @TaskDate";
            var result = await _db.Database.ExecuteSqlRawAsync(query, parameter.ToArray());

            return new ResponseDTO
            {
                Success = result > 0,
                Message = result > 0 ? "Task registered successfully." : "Failed to register task.",
                RowAffected = result
            };


        }
    }
}
