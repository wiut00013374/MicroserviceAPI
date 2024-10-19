using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyMicroserviceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheckController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HealthCheckController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("db")]
        public async Task<IActionResult> CheckDatabase()
        {
            try
            {
                // Attempt to query the database
                await _context.Database.ExecuteSqlRawAsync("SELECT 1");
                return Ok("Database connection is successful!");
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Database connection failed.");
            }
        }
    }
}
