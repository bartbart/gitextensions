using System.Collections.Generic;
using GitFlow.Commands.Impl;

namespace GitFlow.Commands.Builder
{
    public class Builder 
    {
        public Command From(InitInput input)
        {
            return new If(
                new IsGitArchive(),
                new NotFailed(
                    new Log("We can continue."),
                    new Or(
                        new IsRepoHeadless(),
                        new Required( new IsCleanWorkingTree() ) ) ),
                new GitInit());
        }
    }
}