namespace GitFlow.Commands.Impl
{
    class If : Command
    {
        public If(Check check, Command onTrue, Command onFalse)
        {
            Check = check;
            OnTrue = onTrue;
            OnFalse = onFalse;
        }

        private Check Check { get; set; }

        private Command OnTrue { get; set; }

        private Command OnFalse { get; set; }

        public override string Description
        {
            get { return "If"; }
        }

        protected override bool RunCommand(IGit git, ILogger logger)
        {
            CheckResult result = Check.Execute(git, logger);

            if (result == CheckResult.Failed)
            {
                return false;
            }

            if (result == CheckResult.True)
            {
                return OnTrue.Execute(git, logger);
            }
            return OnFalse.Execute(git, logger);
        }
    }
}
