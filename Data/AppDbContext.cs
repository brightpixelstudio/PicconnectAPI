namespace PicconnectAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using PicconnectAPI.Models;
    using PicconnectAPI.Models.Utilities;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // users
        // public DbSet<SelectPlans> SelectPlans { get; set; }

        // statistics
        // public DbSet<GetMostPopularCatagories> GetMostPopularCatagories { get; set; }

        // utilities
        public DbSet<SelectPlans> SelectPlans { get; set; }
    }        
}
