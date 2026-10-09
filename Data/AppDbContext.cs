namespace PicconnectAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using PicconnectAPI.Models;
    using PicconnectAPI.Models.Email;
    using PicconnectAPI.Models.User;
    using PicconnectAPI.Models.Utilities;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // users
        public DbSet<SelectHotCount> SelectHotCount { get; set; }
        public DbSet<SelectMatchSetUsers> SelectMatchSetUsers { get; set; }
        
        // email
        public DbSet<SelectDeletedTotalEmails> SelectDeletedTotalEmails { get; set; }
        public DbSet<SelectEmailCounts> SelectEmailCounts { get; set; }
        public DbSet<SelectEmailHistory> SelectEmailHistory { get; set; }
        public DbSet<SelectFlaggedEmails> SelectFlaggedEmails { get; set; }
        public DbSet<SelectFlaggedTotalEmails> SelectFlaggedTotalEmails { get; set; }
        public DbSet<SelectInboxEmails> SelectInboxEmails { get; set; }
        public DbSet<SelectSentEmails> SelectSentEmails { get; set; }        
        public DbSet<SelectInboxTotalEmails> SelectInboxTotalEmails { get; set; }
        public DbSet<SelectReplyEmailDetails> SelectReplyEmailDetails { get; set; }
        public DbSet<SelectSentTotalEmails> SelectSentTotalEmails { get; set; }
        
        // utilities
        public DbSet<SelectPlans> SelectPlans { get; set; }
        public DbSet<SelectCoordinates> SelectCoordinates { get; set; }
        public DbSet<SelectExpiringMemberships> SelectExpiringMemberships { get; set; }
        public DbSet<SelectCategories> SelectCategories { get; set; }
        public DbSet<SelectMostPopularPhotos> SelectMostPopularPhotos { get; set; }
        public DbSet<SelectLatestNewestUsers> SelectLatestNewestUsers { get; set; }

        // statistics
        // public DbSet<GetMostPopularCatagories> GetMostPopularCatagories { get; set; }

    }
}
