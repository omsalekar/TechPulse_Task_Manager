using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPulse_Task_Manager.DATAACCESS.Interfaces;
using TechPulse_Task_Manager.MODELS.DTO;

namespace TechPulse_Task_Manager.DATAACCESS.Repositories
{
    public class EmployeeService : IEmployeeService
    {
        public Task<ResponseDTO> RegisterEmployeeAsync(RegistrationDTO register)
        {
            var parameter = new List<SqlParameter>();
            {
                new SqlParameter("@FullName", register.FullName);
                new SqlParameter("@PhoneNumber", register.PhoneNumber);
                new SqlParameter("@Email", register.Email);
                new SqlParameter("@Password", register.Password);
                new SqlParameter("@ConfirmPassword", register.ConfirmPassword);
                new SqlParameter("@Designation", register.Designation);
                new SqlParameter("@IsWorkingOnProject", register.IsWorkingOnProject);
                new SqlParameter("@Role", register.Role);
                new SqlParameter("@Role", register.Role);


               
          }
            
        }
    }
}
