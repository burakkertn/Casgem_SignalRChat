using Microsoft.AspNetCore.SignalR;

namespace Casgem_SignalRChat.Hubs
{
    public class Chat:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
