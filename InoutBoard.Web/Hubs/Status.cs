using InoutBoard.Core.Infrastructure.Repositories;
using SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InoutBoard.Web.Hubs
{
    public class Status : Hub, IDisconnect, IConnected
    {
        public Task Disconnect()
        {
            return Clients.leave(Context.ConnectionId, DateTime.Now.ToString());
        }

        public Task Connect()
        {
            //var user = _userRepo.GetUserByEmail(Context.User.Identity.Name);
            return Clients.joined(Context.ConnectionId, DateTime.Now.ToString());
        }

        public Task Reconnect(IEnumerable<string> groups)
        {
            return Clients.rejoined(Context.ConnectionId, DateTime.Now.ToString());
        }
    }
}