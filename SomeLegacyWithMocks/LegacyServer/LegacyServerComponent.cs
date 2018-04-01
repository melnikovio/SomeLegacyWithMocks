using System.Threading;

namespace SomeLegacyWithMocks.LegacyServer
{
    public class LegacyServerComponent
    {
        private LegacyServerInstance _server;

        public LegacyServerComponent(LegacyServerInstance server)
        {
            _server = server;
        }

        public string ExecuteSomeFunction(int timeout)
        {
            Thread.Sleep(timeout);
            return $"Function executed about {timeout} seconds on server {_server.GetServerInstance()}";
        }

        public string ExecuteAnotherFunction(int timeout)
        {
            Thread.Sleep(timeout * 2);
            return $"Function executed about {timeout * 2} seconds on server {_server.GetServerInstance()}";
        }
    }
}
