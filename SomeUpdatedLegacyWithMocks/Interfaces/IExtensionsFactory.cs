namespace SomeUpdatedLegacyWithMocks.Interfaces
{
    public interface IExtensionsFactory
    {
        IExtensionsBase GetExtension<T>(IServerInstance server);
    }
}
