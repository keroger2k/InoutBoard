namespace InoutBoard.Core.Migrations
{
    using InoutBoard.Core.Infrastructure.Providers;
    using System.Data.Entity.Migrations;

    public class MigrationsConfiguration : DbMigrationsConfiguration<InoutContext>
    {
        public MigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

    }
}
