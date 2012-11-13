using System.Collections.Generic;
using GitFlow.Commands.Impl;

namespace GitFlow.Commands.Builder
{
    public class Builder 
    {
        public Command From(InitInput input)
        {
            return new If()
            {
                Check = new IsGitArchive(),
                OnTrue = new CheckAndCommand("Check git.")
                {
                    PreCheck = new Or()
                    {
                        Check1 = new IsRepoHeadless(),
                        Check2 = new Required()
                        {
                            TheCheck = new IsCleanWorkingTree()
                        }
                    },
                    Command = new Log("We are not working in a repo with local changes, we will continue.")
                },
                OnFalse = new GitInit()
            };
        }
    }
}