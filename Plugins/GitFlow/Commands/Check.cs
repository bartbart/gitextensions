using System;

namespace GitFlow.Commands
{
    public abstract class Check
    {
        public abstract string Description { get; }

        public virtual bool IndentLogging
        {
            get { return false; }
        }

        public string AdditionalLogging { set; private get; }

        protected abstract CheckResult RunCheck(IGit git, ILogger logger);

        public CheckResult Execute(IGit git, ILogger logger)
        {
            if (IndentLogging)
            {
                logger.IncrementIndentation();
            }

            CheckResult result = RunCheck(git, logger);

            string logMessage = string.Format("{0} [{1}]", Description, ToMessage(result));
            if (AdditionalLogging != null && AdditionalLogging.Length > 0)
            {
                logMessage += " - " + AdditionalLogging;
            }
            logger.LogLine("Check", logMessage);

            if (IndentLogging)
            {
                logger.DecrementIndentation();
            }

            return result;
        }

        private string ToMessage(CheckResult result)
        {
            switch (result)
            {
                case CheckResult.True:
                    return "   OK";
                case CheckResult.False:
                    return "Not OK";
                case CheckResult.Failed:
                    return "FAILED";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}