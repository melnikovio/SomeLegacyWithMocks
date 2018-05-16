using System;
using SomeUpdatedLegacyWithMocks.Interfaces;

namespace SomeUpdatedLegacyWithMocks.Extensions
{
    public class ExtensionsBase : IExtensionsBase
    {
        private readonly string _extenstionName;
        private IServerInstance _server;

        public ExtensionsBase(IServerInstance server, string extensionName)
        {
            _server = server;
            _extenstionName = extensionName;
        }

        public bool IsExtensionReady
        {
            get
            {
                switch (_extenstionName)
                {
                    case "Hulk":
                        return true;
                    case "Widow":
                        return false;
                }

                throw new ArgumentException();
            }
        }

        public string ExtensionName => _extenstionName;
    }
}
