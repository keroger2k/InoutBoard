
namespace InoutBoard.Core.Infrastructure.Providers
{
    public class DatabaseFactory : IDatabaseFactory
    {

        private InoutContext database;

        public virtual InoutContext Get()
        {
            if (database == null)
            {
                database = new InoutContext();
            }
            return database;
        }

    }
}
