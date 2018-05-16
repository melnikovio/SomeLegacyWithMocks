using SomeUpdatedLegacyWithMocks.Interfaces;

namespace SomeUpdatedLegacyWithMocks.Extensions
{
    public class WidowExtension : ExtensionsBase
    {
        public WidowExtension(IServerInstance server) : base(server, "Widow")
        {
        }
    }
}
