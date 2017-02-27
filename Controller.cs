using System;
using StackExchange.Redis;

namespace PubSub
{
    public class Controller : Client
    {
        protected override void HandleRun(IConnectionMultiplexer redis)
        {
            var subscriber = redis.GetSubscriber();
            for (;;)
                subscriber.Publish("test", Console.ReadLine());
        }
    }
}