using Microsoft.AspNetCore.SignalR;

namespace Web_Server
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message, int color, string username)
        {
            Clients.All.UpdateChatMessage(message, color, username);
        }
    }
}
