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

        protected abstract CheckResult RunCheck(IGit git, ILogger logger);

        public CheckResult Execute(IGit git, ILogger logger)
        {
            if (IndentLogging)
            {
                logger.IncrementIndentation();
            }

            CheckResult result = RunCheck(git, logger);

            if (IndentLogging)
            {
                logger.DecrementIndentation();
            }

            logger.LogLine("Check", string.Format("[{0}] {1}", ToMessage(result), Description));

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