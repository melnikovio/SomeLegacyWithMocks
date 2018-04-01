namespace SomeLegacyWithMocks.LegacyServer
{
    public class LegacyServerInstance
    {
        private string _serverName { get; set; }
        public LegacyServerInstance(string serverName)
        {
            _serverName = serverName;
        }

        public string GetServerInstance()
        {
            return _serverName;
        }
    }
}
