using SomeUpdatedLegacyWithMocks.Interfaces;

namespace SomeUpdatedLegacyWithMocks.Server
{
    public class ServerInstance : IServerInstance
    {
        private string ServerName { get; }
        private IExtensionsFactory ExtensionsFactory { get; }
        public ServerInstance(string serverName, IExtensionsFactory extensionsFactory)
        {
            ServerName = serverName;
            ExtensionsFactory = extensionsFactory;
        }

        public string GetServerInstance()
        {
            return ServerName;
        }

        public string LoadHulkExtension()
        {
            var hulk = ExtensionsFactory.GetHulkExtension(this);
            return $"Extension {hulk.ExtensionName} status: {hulk.IsExtensionReady}";
        }

        public string LoadWidowExtension()
        {
            var widow = ExtensionsFactory.GetWidowExtension(this);
            return $"Extension {widow.ExtensionName} status: {widow.IsExtensionReady}";
        }
    }
}
