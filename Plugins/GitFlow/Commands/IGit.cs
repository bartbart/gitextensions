namespace GitFlow.Commands
{
    public class GitResult
    {
        public GitResult(bool succeeded, string output)
        {
            Succeeded = succeeded;
            Output = output;
        }

        public bool Succeeded { get; private set; }

        public string Output { get; private set; }
    }

    public interface IGit
    {
        GitResult Execute(string arguments);
    }
}