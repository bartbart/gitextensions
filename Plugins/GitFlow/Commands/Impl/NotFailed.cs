namespace GitFlow.Commands.Impl
{
    class NotFailed : Command
    {
        public NotFailed(Command command, Check preCheck)
        {
            Command = command;
            PreCheck = preCheck;
        }

        private Command Command { get; set; }

        private Check PreCheck { get; set; }

        public override string Description
        {
            get { return "Not failed"; }
        }

        protected override bool RunCommand(IGit git, ILogger logger)
        {
            if (PreCheck != null)
            {
                if (PreCheck.Execute(git, logger) == CheckResult.Failed)
                {
                    return false;
                }
            }

            return Command.Execute(git, logger);
        }
    }
}
