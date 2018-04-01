using SomeUpdatedLegacyWithMocks.Interfaces;
using System.Threading;

namespace SomeLegacyWithMocks.LegacyServer
{
    public class ServerComponent : IServerComponent
    {
        private IServerInstance _server;

        public ServerComponent(IServerInstance server)
        {
            _server = server;
        }

        public string ExecuteSomeFunction(int timeout)
        {
            Execute(timeout);
            return $"Function executed about {timeout} seconds on server {_server.GetServerInstance()}";
        }

        public string ExecuteAnotherFunction(int timeout)
        {
            Execute(timeout * 2);
            return $"Function executed about {timeout * 2} seconds on server {_server.GetServerInstance()}";
        }

        public virtual void Execute(int timeout)
        {
            Thread.Sleep(timeout);
        }
    }
}
