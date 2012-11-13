using System;
using GitFlow.Commands;

namespace GitFlow
{
    internal class Logger : ILogger
    {
        public delegate void LogLineHandler(string message);

        private readonly LogLineHandler _logLineHandler;

        private int Indentation { get; set; }

        public Logger(LogLineHandler logLineHandler)
        {
            _logLineHandler = logLineHandler;
            Indentation = 0;
        }

        public void LogLine(string action, string message)
        {
            string prefix = string.Empty;
            for (int i = 0; i < Indentation; ++i)
            {
                prefix += "  ";
            }

            string formattedMessage = "[" + action;
            while (formattedMessage.Length < 9)
            {
                formattedMessage += " ";
            }
            formattedMessage += "] ";
            formattedMessage += prefix + message.Replace(Environment.NewLine, Environment.NewLine + prefix);

            _logLineHandler(formattedMessage);
        }

        public void IncrementIndentation()
        {
            Indentation++;
        }

        public void DecrementIndentation()
        {
            Indentation--;
        }
    }
}