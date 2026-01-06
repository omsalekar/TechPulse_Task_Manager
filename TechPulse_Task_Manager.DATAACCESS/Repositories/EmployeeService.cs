using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TechPulse_Task_Manager.DATAACCESS.ApplicationDbContext;
using TechPulse_Task_Manager.DATAACCESS.Interfaces;
using TechPulse_Task_Manager.MODELS.DTO;

namespace TechPulse_Task_Manager.DATAACCESS.Repositories
{
    public class EmployeeService : IEmployeeService
    {
        private readonly TaskDbContext _dbContext;

        public EmployeeService(TaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ResponseDTO> RegisterEmployeeAsync(RegistrationDTO register)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@FullName", register.FullName),
                new SqlParameter("@PhoneNumber", register.PhoneNumber),
                new SqlParameter("@Email", register.Email),
                new SqlParameter("@Password", register.Password),
                new SqlParameter("@ConfirmPassword", register.ConfirmPassword),
                new SqlParameter("@Designation", register.Designation),
                new SqlParameter("@IsWorkingOnProject", register.IsWorkingOnProject),
                new SqlParameter("@Role", register.Role),
                new SqlParameter("@CreatedAt", register.CreatedAt)
            };
               

            var query = @"EXEC dbo.sp_employee_registration @FullName, @PhoneNumber, @Email, @Password,  @ConfirmPassword, 
@Designation, @IsWorkingOnProject, @Role,@CreatedAt";

            var result = await _dbContext.Database.ExecuteSqlRawAsync(query, parameters.ToArray());

            return new ResponseDTO
            {
                Success = result > 0,
                Message = result > 0 ? "Employee registered successfully" : "Registration failed",
                RowsAffected = result
            };


        }

    }
    }

