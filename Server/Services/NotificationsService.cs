using Microsoft.AspNetCore.SignalR;
using SOS.FMS.Server.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public static class NotificationsService
    {
        public static async Task<string> SendNotification(IHubContext<NotificationHub> hubContext)
        {
            try
            {
                await hubContext.Clients.All.SendAsync("SendMessage", "notification", "Notification");
                return "Success";
            }
            catch
            {
                return "failed";
            }
        }
    }
}
