using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
    public sealed class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("Recive Message", $"{Context.ConnectionId} has joined");
        }

    }
}
