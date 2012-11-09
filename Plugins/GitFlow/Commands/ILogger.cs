namespace GitFlow.Commands
{
    public interface ILogger
    {
        void LogLine(string action, string message);

        void IncrementIndentation();

        void DecrementIndentation();
    }
}