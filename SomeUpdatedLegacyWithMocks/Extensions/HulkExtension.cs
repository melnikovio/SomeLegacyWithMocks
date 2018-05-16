using SomeUpdatedLegacyWithMocks.Interfaces;

namespace SomeUpdatedLegacyWithMocks.Extensions
{
    public class HulkExtension : ExtensionsBase
    {
        public HulkExtension(IServerInstance server) : base(server, "Hulk")
        {
        }
    }
}
