using SomeLegacyWithMocks.LegacyServer;

namespace SomeLegacyWithMocks.ExtensionsForLegacyServer
{
    public class HulkExtension : ExtensionsBase
    {
        public HulkExtension(LegacyServerInstance server) : base(server, "Hulk")
        {
        }
    }
}
