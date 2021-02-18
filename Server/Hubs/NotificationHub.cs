using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendMessage(string user, string title, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, title, message);
        }
    }
}
