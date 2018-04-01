using SomeLegacyWithMocks.LegacyServer;
using System;

namespace SomeLegacyWithMocks
{
    class Program
    {
        private const int DefaultTimeout = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            StartLegacyServerAndExecuteFunctions();
            Console.WriteLine("Finish");
            Console.ReadKey();
        }

        private static void StartLegacyServerAndExecuteFunctions()
        {
            var server = new ServerInstance("Test Updated Server");
            var component = new ServerComponent(server);
            Console.WriteLine(component.ExecuteSomeFunction(DefaultTimeout));
            Console.WriteLine(component.ExecuteAnotherFunction(DefaultTimeout));
        }
    }
}
