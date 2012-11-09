namespace GitFlow.Commands
{
    public interface ICommand
    {
        bool Execute(IGit git, ILogger logger);
    }
}
