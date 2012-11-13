namespace GitFlow.Commands.Impl
{
    class If : Command
    {
        public Check Check { get; set; }

        public Command OnTrue { get; set; }

        public Command OnFalse { get; set; }

        public override string Description
        {
            get { return "If"; }
        }

        protected override bool RunCommand(IGit git, ILogger logger)
        {
            logger.IncrementIndentation();
            CheckResult result = Check.Execute(git, logger);
            logger.DecrementIndentation();

            if (result == CheckResult.Failed)
            {
                return false;
            }

            bool actionResult = false;

            if (result == CheckResult.True)
            {
                logger.LogLine("", "Then");
                logger.LogLine("", "{");

                logger.IncrementIndentation();
                actionResult = OnTrue.Execute(git, logger);
                logger.DecrementIndentation();
            }
            else
            {
                logger.LogLine("", "Else");
                logger.LogLine("", "{");
                logger.IncrementIndentation();
                actionResult = OnFalse.Execute(git, logger);
                logger.DecrementIndentation();
            }

            logger.LogLine("", "}");

            return actionResult;
        }
    }
}
