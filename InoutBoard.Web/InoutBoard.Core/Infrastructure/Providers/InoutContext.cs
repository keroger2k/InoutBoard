using InoutBoard.Core.Models;
using System.Data.Entity;

namespace InoutBoard.Core.Infrastructure.Providers
{
    public class InoutContext : DbContext
    {
        public InoutContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}