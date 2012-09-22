using InoutBoard.Core.Models;
using InoutBoard.Core.Models.Mappings;
using System.Data.Entity;

namespace InoutBoard.Core.Infrastructure.Providers
{
    public class InoutContext : DbContext
    {
        public InoutContext()
            : base("Inout")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BoardUserMap());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BoardUser> BoardUsers { get; set; }

    }
}