namespace GitFlow.Commands
{
    public abstract class Command
    {
        public abstract string Description { get; }

        public virtual bool IndentLogging
        {
            get { return true; }
        }

        protected abstract bool RunCommand(IGit git, ILogger logger);

        public bool Execute(IGit git, ILogger logger)
        {
            if (IndentLogging)
            {
                logger.IncrementIndentation();
            }

            logger.LogLine("Command", Description);

            bool result = RunCommand(git, logger);

            if (IndentLogging)
            {
                logger.DecrementIndentation();
            }

            return result;
        }
    }
}
