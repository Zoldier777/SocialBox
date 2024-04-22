using Microsoft.AspNetCore.SignalR;

namespace SocialBoxAPI.Hubs
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync() =>
            await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId} has joined" );
        
        public async Task NewMessage(long username, string message) =>
            await Clients.All.SendAsync("messageReceived", username, message);
        
    }
}
