namespace SomeUpdatedLegacyWithMocks.Interfaces
{
    public interface IServerComponent
    {
        string ExecuteSomeFunction(int timeout);

        string ExecuteAnotherFunction(int timeout);

        void Execute(int timeout);
    }
}
