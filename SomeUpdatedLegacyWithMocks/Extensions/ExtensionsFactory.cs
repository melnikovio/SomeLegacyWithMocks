using System;
using SomeUpdatedLegacyWithMocks.Interfaces;

namespace SomeUpdatedLegacyWithMocks.Extensions
{
    public class ExtensionsFactory : IExtensionsFactory
    {
        IExtensionsBase IExtensionsFactory.GetExtension<T>(IServerInstance server)
        {
            return Activator.CreateInstance(typeof(T), server) as IExtensionsBase;
        }

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
