using Microsoft.AspNetCore.Mvc;
using TechPulse_Task_Manager.DATAACCESS.Interfaces;
using TechPulse_Task_Manager.MODELS.DTO;

namespace TechPulse_Task_Manager.WebAPI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpPost]
        [Route("Register-Employee")]
       
        public async Task<IActionResult> Register([FromBody] RegistrationDTO register)
        {
            var result = await _unitOfWork._employeeService.RegisterEmployeeAsync(register);

            return Ok(result);
        }
    }
}
