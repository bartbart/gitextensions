namespace GitFlow.Commands.Impl
{
    class GitInit : Command
    {
        public override string Description 
        {
            get { return "Git init"; }
        }

        protected override bool RunCommand(IGit git, ILogger logger)
        {
            GitResult result = git.Execute("init");

            if (!result.Succeeded)
            {
                return false;
            }
            return true;
        }
    }
}
