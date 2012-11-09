using GitFlow.Commands;
using GitUIPluginInterfaces;

namespace GitFlow
{
    class Git : IGit
    {
        private readonly IGitModule _gitModule;
        
        public Git(IGitModule gitModule)
        {
            _gitModule = gitModule;
        }

        public GitResult Execute(string arguments)
        {
            int exitCode;
            string output = _gitModule.RunGit(arguments, out exitCode);

            return new GitResult(exitCode == 0, output);
        }
    }
}