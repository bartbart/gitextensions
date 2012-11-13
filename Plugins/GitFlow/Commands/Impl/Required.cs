namespace GitFlow.Commands.Impl
{
    class Required : Check
    {
        public override bool IndentLogging
        {
            get { return true; }
        }

        public Check TheCheck { get; set; }

        public override string Description
        {
            get { return "Required: " + TheCheck.Description; }
        }

        protected override CheckResult RunCheck(IGit git, ILogger logger)
        {
            CheckResult result = TheCheck.Execute(git, logger);

            if (result == CheckResult.True)
            {
                return CheckResult.True;
            }
            
            return CheckResult.Failed;
        }
    }
}
