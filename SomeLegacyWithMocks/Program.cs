using SomeLegacyWithMocks.LegacyServer;
using System;
using SomeLegacyWithMocks.ExtensionsForLegacyServer;

namespace SomeLegacyWithMocks
{
    class Program
    {
        private const int DefaultTimeout = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            StartLegacyServerAndExecuteFunctions();
            CheckExtensions();
            Console.WriteLine("Finish");
            Console.ReadKey();
        }

        private static void StartLegacyServerAndExecuteFunctions()
        {
            var server = new LegacyServerInstance("Test Legacy Server");
            var component = new LegacyServerComponent(server);
            Console.WriteLine(component.ExecuteSomeFunction(DefaultTimeout));
            Console.WriteLine(component.ExecuteAnotherFunction(DefaultTimeout));
        }

        private static void CheckExtensions()
        {
            var server = new LegacyServerInstance("Test Legacy Server with extensions");
            Console.WriteLine(server.LoadHulkExtension());
            Console.WriteLine(server.LoadWidowExtension());
        }
    }
}
