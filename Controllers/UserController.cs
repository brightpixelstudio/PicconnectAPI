using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using PicconnectAPI.Data;
using PicconnectAPI.Models.User;

namespace PicconnectAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpDelete(Name = "DeleteHotUser")]
        public async Task<ActionResult> DeleteHotUser(int hotuserid, int userId)
        {
            var affectedRows = await _context.Database.ExecuteSqlRawAsync(
                "CALL delete_hotuser({0}, {1})", hotuserid, userId);

            return Ok(new { message = "Hot User successfully deleted" });
        }

        [HttpDelete(Name = "DeleteUser")]
        public async Task<ActionResult> DeleteUser(int userId)
        {
            var affectedRows = await _context.Database.ExecuteSqlRawAsync(
                "CALL delete_user({0})", userId);

            return Ok(new { message = "User successfully deleted" });
        }

    }
}
