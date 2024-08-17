using Microsoft.AspNetCore.SignalR;

namespace WebAPI_Domain.SignalR
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }

        public override Task OnConnectedAsync()
        {
            // Log or use the connection ID when a client connects
            string connectionId = Context.ConnectionId;
            // Optionally store this connection ID somewhere
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            // Handle client disconnection
            string connectionId = Context.ConnectionId;
            // Optionally remove this connection ID from tracking
            return base.OnDisconnectedAsync(exception);
        }
    }
}
