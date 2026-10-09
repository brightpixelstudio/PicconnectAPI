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

        [HttpDelete(Name = "DeleteUserMatchset")]
        public async Task<ActionResult> DeleteUserMatchset(string usermatchprofileguid)
        {
            var affectedRows = await _context.Database.ExecuteSqlRawAsync(
                "CALL delete_usermatchset({0})", usermatchprofileguid);

            return Ok(new { message = "User Matchset successfully deleted" });
        }

        [HttpDelete(Name = "DeleteUserSettings")]
        public async Task<ActionResult> DeleteUserSettings(string userid)
        {
            var affectedRows = await _context.Database.ExecuteSqlRawAsync(
                "CALL delete_usersettings({0})", userid);

            return Ok(new { message = "User Setting successfully deleted" });
        }

        [HttpDelete(Name = "DeleteUserViewedProfile")]
        public async Task<ActionResult> DeleteUserViewedProfile(int daysIn)
        {
            var affectedRows = await _context.Database.ExecuteSqlRawAsync(
                "CALL delete_userviewedprofile({0})", daysIn);

            return Ok(new { message = "User Viewed Profile was successfully deleted" });
        }

        [HttpGet(Name = "SelectHotCount")]
        public async Task<ActionResult<IEnumerable<SelectHotCount>>> SelectHotCount(int userid, int type)
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@useridIn", userid);
            var typeIn = new MySqlParameter("@typeIn", type);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectHotCount
                .FromSqlRaw("CALL select_hotcount({0}, {1})", useridIn, typeIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectMatchSetUsers")]
        public async Task<ActionResult<IEnumerable<SelectMatchSetUsers>>> SelectMatchSetUsers(int matchsetprofileguid, int maxrecords)
        {
            // Define the parameter to prevent SQL Injection
            var matchsetprofileguidIn = new MySqlParameter("@matchsetprofileguidIn", matchsetprofileguid);
            var maxrecordsIn = new MySqlParameter("@maxrecordsIn", maxrecords);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectMatchSetUsers
                .FromSqlRaw("CALL select_matchsetusers({0}, {1})", matchsetprofileguidIn, maxrecordsIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectMatchUserList")]
        public async Task<ActionResult<IEnumerable<SelectMatchUserList>>> SelectMatchUserList(int userid, string usermatchprofileguid, int photocount, float lat, 
            float lng, int listtypeid, int excludeblocks, int maxrecords, int sex )
        {
            // Define the parameter to prevent SQL Injection
            var useridIn = new MySqlParameter("@p_userid", userid);
            var usermatchprofileguidIn = new MySqlParameter("@p_usermatchprofileguid", usermatchprofileguid);
            var photocountIn = new MySqlParameter("@p_photocount", photocount);
            var latIn = new MySqlParameter("@p_lat", lat);
            var lngIn = new MySqlParameter("@p_lng", lng);
            var listtypeidIn = new MySqlParameter("@p_listtypeid", listtypeid);
            var excludeblocksIn = new MySqlParameter("@p_excludeblocks", excludeblocks);
            var maxrecordsIn = new MySqlParameter("@p_maxrecords", maxrecords);
            var sexIn = new MySqlParameter("@p_sex", sex);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectMatchUserList
                .FromSqlRaw("CALL select_matchuserlist({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, )", useridIn, usermatchprofileguidIn, photocountIn, latIn, lngIn, listtypeidIn, excludeblocksIn, maxrecordsIn, sexIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }
    }
}
