namespace GitFlow.Commands.Impl
{
    class CheckAndCommand : Command
    {
        private string _description;

        public CheckAndCommand(string description)
        {
            _description = description;
        }

        public Command Command { get; set; }

        public Check PreCheck { get; set; }

        public override string Description
        {
            get { return _description; }
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
