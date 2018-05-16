using SomeLegacyWithMocks.ExtensionsForLegacyServer;

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

        public string LoadHulkExtension()
        {
            var hulk = new HulkExtension(this);
            return $"Extension {hulk.ExtensionName} status: {hulk.IsExtensionReady}";
        }

        public string LoadWidowExtension()
        {
            var widow = new WidowExtension(this);
            return $"Extension {widow.ExtensionName} status: {widow.IsExtensionReady}";
        }
    }
}
