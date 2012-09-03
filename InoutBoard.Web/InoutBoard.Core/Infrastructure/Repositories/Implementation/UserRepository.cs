using InoutBoard.Core.Infrastructure.Providers;
using InoutBoard.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoutBoard.Core.Infrastructure.Repositories.Implementation
{
    public class UserRepository : RepositoryBase<UserProfile>, IUserRepository {
        public UserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }

        public UserProfile GetUserByName(string username)
        {
            return Database.UserProfiles.
                SingleOrDefault(user => user.UserName.Equals(username, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
