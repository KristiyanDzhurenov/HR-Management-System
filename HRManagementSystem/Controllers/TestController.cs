using HRManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly HRDbContext _context;

        public TestController(HRDbContext context)
        {
            _context = context;
        }

        [HttpGet("employees")]
        public IActionResult GetEmployees()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API is working!");
        }
    }
}
