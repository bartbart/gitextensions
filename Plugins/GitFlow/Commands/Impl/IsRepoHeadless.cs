namespace GitFlow.Commands.Impl
{
    class IsRepoHeadless : Check
    {
        public override string Description
        {
            get { return "Is the repository headless."; }
        }

        protected override CheckResult RunCheck(IGit git, ILogger logger)
        {
            GitResult result = git.Execute("rev-parse --quiet --verify HEAD");

            if (!result.Succeeded && result.Output == string.Empty)
            {
                return CheckResult.True;
            }

            if (!result.Succeeded)
            {
                return CheckResult.Failed;
            }

            return CheckResult.False;
        }
    }
}
