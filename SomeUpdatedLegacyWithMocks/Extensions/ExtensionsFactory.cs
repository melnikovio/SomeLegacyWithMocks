using System;
using SomeUpdatedLegacyWithMocks.Interfaces;

namespace SomeUpdatedLegacyWithMocks.Extensions
{
    public class ExtensionsFactory : IExtensionsFactory
    {
        public IExtensionsBase GetHulkExtension(IServerInstance server)
        {
            return new HulkExtension(server);
        }

        public IExtensionsBase GetWidowExtension(IServerInstance server)
        {
            return new WidowExtension(server);
        }
    }
}
