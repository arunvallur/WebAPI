using Microsoft.AspNetCore.SignalR;
using WebAPI_Domain.SignalR;
using WebAPI_Domain_Contract;

namespace WebAPI_Domain
{
    public class NotificationManager : INotificationManager
    {
        private readonly IHubContext<NotificationHub> _hubContext;
        public NotificationManager(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task<bool> pushNotification(string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", message);
            return true;
        }
    }
}
