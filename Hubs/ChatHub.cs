using Microsoft.AspNetCore.SignalR;
using SignalR.Services;
using System;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ChatServices _chatServices;
        public ChatHub(ChatServices chatService)
        {
            _chatServices = chatService;
        }
        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, "Conn2Chat");
            await Clients.Caller.SendAsync("UserConnected");

        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "Conn2Chat");
            await base.OnDisconnectedAsync(exception);


        }

    }
}
