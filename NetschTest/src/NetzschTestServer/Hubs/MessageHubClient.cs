using Microsoft.AspNetCore.SignalR;

namespace NetzschTestServer.Hubs
{
    public class MessageHubClient : Hub
    {
        public async Task SendMessageToUser(long username,string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",username, message);
        }
    }
}
