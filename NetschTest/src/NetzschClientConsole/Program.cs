using Microsoft.AspNetCore.SignalR.Client;

var random = new Random();
long username = random.NextInt64();

Console.WriteLine("Netzch Message");

var connection = new HubConnectionBuilder()
    .WithUrl("http://localhost:4000/message")
    .Build();


connection.On("ReceiveMessage", (long username, string message) => Console.WriteLine($"Receive username: {username} message: {message}"));


await connection.StartAsync();

Console.WriteLine("Connected...");

//await connection.InvokeAsync<string>("SendMessageToUser",,"Start message");


string input = String.Empty;
do
{
    input = Console.ReadLine();
    if (!String.IsNullOrWhiteSpace(input))
    {
        await connection.InvokeAsync<string>("SendMessageToUser", username, input);
    }    
} while (!String.IsNullOrWhiteSpace(input));

await connection.StopAsync();
Console.WriteLine("Disconnecting");