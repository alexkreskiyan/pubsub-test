using System;
using StackExchange.Redis;

namespace PubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = GetClient(args);
            if (client == null)
            {
                Console.WriteLine("Unknown role");
                return;
            }

            Console.WriteLine("Pub/Sub test");
            using (var connection = GetConnection())
            {
                client.Run(connection);
            }
        }

        private static IClient GetClient(string[] args)
        {
            if (args.Length != 1)
                return null;

            switch (args[0])
            {
                case "controller":
                    return new Controller();
                case "listener":
                    return new Listener();
                default:
                    return null;
            }
        }

        private static ConnectionMultiplexer GetConnection()
        {
            var redisConfiguration = new ConfigurationOptions();
            redisConfiguration.ResolveDns = true;
            redisConfiguration.EndPoints.Add("127.0.0.1");

            return ConnectionMultiplexer.Connect(redisConfiguration);
        }
    }
}