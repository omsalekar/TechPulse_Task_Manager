using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechPulse_Task_Manager.WebAPI.Data;
using TechPulse_Task_Manager.WebAPI.DTO;

namespace TechPulse_Task_Manager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TaskDbContext _context;
        public AuthController(TaskDbContext context)
        {
            _context = context;
        }
       
      
    }
}
