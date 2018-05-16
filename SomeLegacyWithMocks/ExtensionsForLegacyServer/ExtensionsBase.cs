using System;
using SomeLegacyWithMocks.LegacyServer;

namespace SomeLegacyWithMocks.ExtensionsForLegacyServer
{
    public class ExtensionsBase
    {
        private readonly string _extenstionName;
        private LegacyServerInstance _server;

        public ExtensionsBase(LegacyServerInstance server, string extensionName)
        {
            _server = server;
            _extenstionName = extensionName;
        }

        public bool IsExtensionReady
        {
            get
            {
                if (_extenstionName == "Hulk")
                    return true;
                if (_extenstionName == "Widow")
                    return false;

                throw new ArgumentException();
            }
        }

        public string ExtensionName => _extenstionName;
    }
}
