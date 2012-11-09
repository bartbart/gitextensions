namespace GitFlow.Commands.Impl
{
    class IsGitArchive: Check
    {
        public override string Description
        {
            get { return "Is the folder under version control."; }
        }

        protected override CheckResult RunCheck(IGit git, ILogger logger)
        {
            GitResult result = git.Execute("rev-parse --git-dir");

            if(result.Succeeded)
            {
                return CheckResult.True;
            }
            if (result.Output.Contains("Not a git repository"))
            {
                return CheckResult.False;
            }
            return CheckResult.Failed;
        }
    }
}
