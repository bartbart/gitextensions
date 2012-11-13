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
            GitResult resultHasUnstagedChanges = git.Execute("diff --no-ext-diff --ignore-submodules --quiet --exit-code");

            if (!resultHasUnstagedChanges.Succeeded)
            {
                AdditionalLogging = "Working tree contains unstaged changes.";
                return CheckResult.False;
            }

            GitResult resultIndexContainsUncommitedChanges = git.Execute("diff-index --cached --quiet --ignore-submodules HEAD --");

            if (!resultIndexContainsUncommitedChanges.Succeeded)
            {
                AdditionalLogging = "Index contains uncommited changes.";
                return CheckResult.False;
            }

            return CheckResult.True;
        }
    }
}
