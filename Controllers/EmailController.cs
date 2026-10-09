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

        [HttpGet(Name = "SelectEmailCounts")]
        public async Task<ActionResult<IEnumerable<SelectEmailCounts>>> SelectEmailCounts(int userid)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectEmailCounts
                .FromSqlRaw("CALL select_emailcounts({0})", useridIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectEmailHistory")]
        public async Task<ActionResult<IEnumerable<SelectEmailHistory>>> SelectEmailHistory(string useremailguid)
        {
            // Define the parameter to prevent SQL Injection
            var useremailguidIn = new MySqlParameter("@useremailguidIn", useremailguid);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectEmailHistory
                .FromSqlRaw("CALL select_emailhistory({0})", useremailguidIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectFlaggedEmails")]
        public async Task<ActionResult<IEnumerable<SelectFlaggedEmails>>> SelectFlaggedEmails(int userid, int orderfield, int top)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);
            var orderfieldIn = new MySqlParameter("@orderfieldIn", orderfield);
            var topIn = new MySqlParameter("@topIn", top);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectFlaggedEmails
                .FromSqlRaw("CALL select_flaggedemails({0}, {1}, {2})", useridIn, orderfieldIn, topIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectFlaggedTotalEmails")]
        public async Task<ActionResult<IEnumerable<SelectFlaggedTotalEmails>>> SelectFlaggedTotalEmails(int userid)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectFlaggedTotalEmails
                .FromSqlRaw("CALL select_flaggedtotalemails({0})", useridIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectInboxEmails")]
        public async Task<ActionResult<IEnumerable<SelectInboxEmails>>> SelectInboxEmails(int userid, int orderfield, int top)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);
            var orderfieldIn = new MySqlParameter("@orderfieldIn", orderfield);
            var topIn = new MySqlParameter("@topIn", top);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectInboxEmails
                .FromSqlRaw("CALL select_inboxemails({0}, {1}, {2})", useridIn, orderfieldIn, topIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        public async Task<ActionResult<IEnumerable<SelectInboxTotalEmails>>> SelectInboxTotalEmails(int userid)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectInboxTotalEmails
                .FromSqlRaw("CALL select_inboxtotalemails({0})", useridIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectReplyEmailDetails")]
        public async Task<ActionResult<IEnumerable<SelectReplyEmailDetails>>> SelectReplyEmailDetails(int userid, int userguid)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);
            var userguidIn = new MySqlParameter("@userguidIn", userguid);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectReplyEmailDetails
                .FromSqlRaw("CALL select_replyemaildetails({0}, {1}", useridIn, userguidIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectSentEmails")]
        public async Task<ActionResult<IEnumerable<SelectSentEmails>>> SelectSentEmails(int userid, int orderfield, int top)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);
            var orderfieldIn = new MySqlParameter("@orderfieldIn", orderfield);
            var topIn = new MySqlParameter("@topIn", top);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectSentEmails
                .FromSqlRaw("CALL select_sentemails({0}, {1}, {2})", useridIn, orderfieldIn, topIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectSentTotalEmails")]
        public async Task<ActionResult<IEnumerable<SelectSentTotalEmails>>> SelectSentTotalEmails(int userid)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectSentTotalEmails
                .FromSqlRaw("CALL select_senttotalemails({0})", useridIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }
    }
}
