namespace SomeUpdatedLegacyWithMocks.Interfaces
{
    public interface IExtensionsFactory
    {
        IExtensionsBase GetHulkExtension(IServerInstance server);
        IExtensionsBase GetWidowExtension(IServerInstance server);
    }
}
