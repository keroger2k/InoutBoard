using InoutBoard.Core.Infrastructure.Providers;
using InoutBoard.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoutBoard.Core.Infrastructure.Repositories.Implementation
{
    public class UserRepository : RepositoryBase<BoardUser>, IUserRepository {
        public UserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }

        public BoardUser GetUserByEmail(string email)
        {
            return Database.BoardUsers.
                SingleOrDefault(user => user.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
