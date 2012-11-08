using System;
using GitUIPluginInterfaces;

namespace GitFlow.GitFlowCommands
{
    class GitFlowCommander
    {
        private IGitModule iGitCommands;

        internal GitFlowCommander(IGitModule iGitCommands)
        {
            this.iGitCommands = iGitCommands;
        }

        internal bool HasUnstagedChanged
        {
            get
            {
                return iGitCommands.RunGit("diff --no-ext-diff --ignore-submodules --quiet --exit-code") == string.Empty;
            }
        }

        internal bool IsGitRepo
        {
            get
            {
                return iGitCommands.RunGit("rev-parse --git-dir") != string.Empty;
            }
        }

        internal bool IsGitRepoHeadless
        {
            get
            {
                return iGitCommands.RunGit("rev-parse --quiet --verify HEAD") == string.Empty;
            }
        }

        internal void RequireCleanWorkingTree()
        {
            if (HasUnstagedChanged)
            {

            }
        }

        internal void ExecuteGitInit()
        {
            throw new NotImplementedException();
        }

    }
}
