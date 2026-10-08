namespace PicconnectAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using PicconnectAPI.Models;
    using PicconnectAPI.Models.Utilities;
    using PicconnectAPI.Models.Email;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // users
        // public DbSet<SelectPlans> SelectPlans { get; set; }

        // statistics
        // public DbSet<GetMostPopularCatagories> GetMostPopularCatagories { get; set; }

        // email
        public DbSet<SelectDeletedTotalEmails> SelectDeletedTotalEmails { get; set; }

        // utilities
        public DbSet<SelectPlans> SelectPlans { get; set; }
        public DbSet<SelectCoordinates> SelectCoordinates { get; set; }
        public DbSet<SelectExpiringMemberships> SelectExpiringMemberships { get; set; }
        public DbSet<SelectCategories> SelectCategories { get; set; }
        public DbSet<SelectMostPopularPhotos> SelectMostPopularPhotos { get; set; }
        public DbSet<SelectLatestNewestUsers> SelectLatestNewestUsers { get; set; }



    }        
}
