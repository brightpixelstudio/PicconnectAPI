using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
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
                .FromSqlRaw("CALL select_plans()")
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectCoordinates")]
        public async Task<ActionResult<IEnumerable<SelectCoordinates>>> SelectCoordinates(int zipcode)
        {
            // Define the parameter to prevent SQL Injection
            var zipcodeIn = new MySqlParameter("@zipcodeIn", zipcode);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectCoordinates
                .FromSqlRaw("CALL select_coordinates({0})", zipcodeIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectExpiringMemberships")]
        public async Task<ActionResult<IEnumerable<SelectExpiringMemberships>>> SelectExpiringMemberships(int days)
        {
            // Define the parameter to prevent SQL Injection
            var daysIn = new MySqlParameter("@daysIn", days);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectExpiringMemberships
                .FromSqlRaw("CALL select_expiringmemberships({0})", daysIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectCategories")]
        public async Task<ActionResult<IEnumerable<SelectCategories>>> SelectCategories()
        {
            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectCategories
                .FromSqlRaw("CALL select_categories()")
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectMostPopularPhotos")]
        public async Task<ActionResult<IEnumerable<SelectMostPopularPhotos>>> SelectMostPopularPhotos(int rating)
        {
            // Define the parameter to prevent SQL Injection
            var ratingIn = new MySqlParameter("@ratingIn", rating);

            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectMostPopularPhotos
                .FromSqlRaw("CALL select_mostpopularphotos({0})", ratingIn)
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }

        [HttpGet(Name = "SelectLatestNewestUsers")]
        public async Task<ActionResult<IEnumerable<SelectLatestNewestUsers>>> SelectLatestNewestUsers()
        {
            // MySQL utilizes the 'CALL' syntax
            var getrecords = await _context.SelectLatestNewestUsers
                .FromSqlRaw("CALL select_latestnewestusers()")
                .ToListAsync();

            if (getrecords.Count == 0)
                return NotFound();

            // return results
            return Ok(getrecords);
        }
        
    }
}
