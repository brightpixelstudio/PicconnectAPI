using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PicconnectAPI.Data;
using PicconnectAPI.Models.Utilities;

namespace PicconnectAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UtilityController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UtilityController> _logger;

        public UtilityController(ILogger<UtilityController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "SelectPlans")]
        public async Task<ActionResult<IEnumerable<SelectPlans>>> SelectPlans()
        {
            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectPlans
                .FromSqlRaw("CALL SelectPlans()")
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }
    }
}
