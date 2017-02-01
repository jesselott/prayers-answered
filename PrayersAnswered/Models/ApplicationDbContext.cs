using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace PrayersAnswered.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Prayer> Prayers { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}