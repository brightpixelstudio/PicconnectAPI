using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using PicconnectAPI.Data;
using PicconnectAPI.Models.Email;

namespace PicconnectAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmailController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UtilityController> _logger;

        public EmailController(ILogger<UtilityController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "SelectDeletedTotalEmails")]
        public async Task<ActionResult<IEnumerable<SelectDeletedTotalEmails>>> SelectDeletedTotalEmails(int userid)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectDeletedTotalEmails
                .FromSqlRaw("CALL select_deletedtotalemails({0})", useridIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }
    }
}
