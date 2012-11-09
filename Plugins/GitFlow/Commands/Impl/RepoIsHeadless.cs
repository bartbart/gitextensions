namespace GitFlow.Commands.Impl
{
    class RepoIsHeadless : ICommand
    {
        public bool Execute(IGit git, ILogger logger)
        {
            logger.LogLine("Checking whether repo is headless.");

            if (git.Execute("rev-parse --quiet --verify HEAD") == string.Empty)
            {
                logger.LogLine("Repo is headless.");
                return true;
            }

            logger.LogLine("Repo is not headless.");
            return true;
        }
    }
}
