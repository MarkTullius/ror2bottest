using System;

namespace ror2BotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IrcClient client = new IrcClient("irc.twitch.tv", 6667, "ror2bottest", "oauth:i5pscx6ze0z9epaqbln187fdpjtg25", "marktullius");

            var pinger = new Pinger(client);
            pinger.Start();

            while(true)
            {
                Console.WriteLine("Reading message");
                var message = client.ReadMessage();
                Console.WriteLine($"Message: {message}");

                if (message.Contains("!doment"))
                {
                    Console.WriteLine($"+1 doment");
                }
            }
        }
    }
}
