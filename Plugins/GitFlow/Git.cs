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

        public string Execute(string arguments)
        {
            return _gitModule.RunGit(arguments);
        }
    }
}