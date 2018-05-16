using System;
using SomeUpdatedLegacyWithMocks.Extensions;
using SomeUpdatedLegacyWithMocks.Interfaces;
using SomeUpdatedLegacyWithMocks.Server;

namespace SomeUpdatedLegacyWithMocks
{
    class Program
    {
        private const int DefaultTimeout = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var server = new ServerInstance("Test Updated Server", new ExtensionsFactory());
            var component = new ServerComponent(server);
            StartLegacyServerAndExecuteFunctions(component);
            CheckExtensions(server);
            Console.WriteLine("Finish");
            Console.ReadKey();
        }

        private static void StartLegacyServerAndExecuteFunctions(IServerComponent serverComponent)
        {
            Console.WriteLine(serverComponent.ExecuteSomeFunction(DefaultTimeout));
            Console.WriteLine(serverComponent.ExecuteAnotherFunction(DefaultTimeout));
        }

        private static void CheckExtensions(IServerInstance server)
        {
            Console.WriteLine(server.LoadHulkExtension());
            Console.WriteLine(server.LoadWidowExtension());
        }
    }
}
