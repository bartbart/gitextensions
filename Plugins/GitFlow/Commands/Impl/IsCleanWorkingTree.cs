namespace GitFlow.Commands.Impl
{
    class IsCleanWorkingTree : Check
    {
        public override string Description 
        {
            get { return "Is the working tree clean."; }
        }

        protected override CheckResult RunCheck(IGit git, ILogger logger)
        {
            //GitResult result = git.RunCommand("rev-parse --quiet --verify HEAD");

            return CheckResult.False;
        }
    }
}
