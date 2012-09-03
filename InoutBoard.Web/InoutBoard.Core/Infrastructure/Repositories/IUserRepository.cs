using InoutBoard.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoutBoard.Core.Infrastructure.Repositories
{
    public interface IUserRepository : IRepository<UserProfile>
    {
        UserProfile GetUserByName(string username);
    }
}
