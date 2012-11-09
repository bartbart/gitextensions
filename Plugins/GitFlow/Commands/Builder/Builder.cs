using System.Collections.Generic;

namespace GitFlow.Commands.Builder
{
    public class Builder 
    {
        public List<ICommand> From(InitInput input)
        {
            return new List<ICommand>()
                       {
                           new RepoIsHeadless(),
                       };
        }
    }
}