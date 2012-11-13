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

            if (result == CheckResult.Failed)
            {
                return false;
            }

            if (result == CheckResult.True)
            {
                logger.DecrementIndentation();

                return OnTrue.Execute(git, logger);
            }

            logger.DecrementIndentation();

            return OnFalse.Execute(git, logger);
        }
    }
}
