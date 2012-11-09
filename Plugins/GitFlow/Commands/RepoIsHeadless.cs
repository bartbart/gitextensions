namespace GitFlow.Commands
{
    class RepoIsHeadless : ICommand
    {
        public bool Execute(IGit git, ILogger logger)
        {
            logger.LogLine("Checking whether repo is headless.");
            return git.Execute("rev-parse --quiet --verify HEAD") == string.Empty;
        }
    }
}
