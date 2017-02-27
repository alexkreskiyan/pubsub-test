using System;
using StackExchange.Redis;

namespace PubSub
{
    public class Listener : Client
    {
        protected override void HandleRun(IConnectionMultiplexer redis)
        {
            var subscriber = redis.GetSubscriber();
            subscriber.Subscribe("test", (channel, message) => Console.WriteLine(message));
        }
    }
}