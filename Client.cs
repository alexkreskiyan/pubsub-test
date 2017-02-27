using System;
using System.Runtime.Loader;
using System.Threading;
using StackExchange.Redis;

namespace PubSub
{
    public abstract class Client
    {
        private readonly ManualResetEventSlim gate = new ManualResetEventSlim();

        protected Client()
        {
            AssemblyLoadContext.Default.Unloading += context =>
            {
                gate.Set();
                gate.Dispose();
                Console.WriteLine("END");
            };
        }

        public void Run(IConnectionMultiplexer redis)
        {
            gate.Reset();
            HandleRun(redis);
            gate.Wait();
        }

        protected abstract void HandleRun(IConnectionMultiplexer redis);
    }
}