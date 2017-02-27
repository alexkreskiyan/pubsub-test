using StackExchange.Redis;

namespace PubSub
{
    public interface IClient
    {
        void Run(IConnectionMultiplexer redis);
    }
}