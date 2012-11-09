using GitFlow.Commands;

namespace GitFlow
{
    internal class Logger : ILogger
    {
        public delegate void LogLineHandler(string message);

        private readonly LogLineHandler _logLineHandler;

        public Logger(LogLineHandler logLineHandler)
        {
            _logLineHandler = logLineHandler;
        }

        public void LogLine(string message)
        {
            _logLineHandler(message);
        }
    }
}