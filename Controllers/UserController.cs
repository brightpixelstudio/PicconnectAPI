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
            // Define the parameter to prevent SQL Injection
            var hotuserIn = new MySqlParameter("@hotuserIn", hotuserid);
            var userIdIn = new MySqlParameter("@useridIn", userId);

            // add the record
            var affectedRows = _context.Database.ExecuteSqlRaw(
                "CALL delete_hotuser({0}, {1})", hotuserIn, userIdIn);

            return Ok(new { message = "Hot User successfully deleted" });
        }




    }
}
