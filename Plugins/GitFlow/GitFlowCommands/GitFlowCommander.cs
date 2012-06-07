using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitUIPluginInterfaces;

namespace GitFlow.GitFlowCommands
{
    class GitFlowCommander
    {
        private IGitCommands iGitCommands;

        internal GitFlowCommander(IGitCommands iGitCommands)
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
