using SomeUpdatedLegacyWithMocks.Interfaces;

namespace SomeLegacyWithMocks.LegacyServer
{
    public class ServerInstance : IServerInstance
    {
        private string _serverName { get; set; }
        public ServerInstance(string serverName)
        {
            _serverName = serverName;
        }

        public string GetServerInstance()
        {
            return _serverName;
        }
    }
}
