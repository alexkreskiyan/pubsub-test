using System;
using StackExchange.Redis;

namespace PubSub
{
    public class Controller : IClient
    {
        public void Run(IConnectionMultiplexer redis)
        {
            Console.WriteLine("Running Controller");
        }
    }
}