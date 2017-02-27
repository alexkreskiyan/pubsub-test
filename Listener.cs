using System;
using StackExchange.Redis;

namespace PubSub
{
    public class Listener : IClient
    {
        public void Run(IConnectionMultiplexer redis)
        {
            Console.WriteLine("Running Listener");
        }
    }
}