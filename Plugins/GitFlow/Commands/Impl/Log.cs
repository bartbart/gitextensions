namespace GitFlow.Commands.Impl
{
    class Log : Command
    {
        public Log(string message)
        {
            Message = message;
        }

        public override string Description
        {
            get { return Message; }
        }

        private string Message { get; set; }

        protected override bool RunCommand(IGit git, ILogger logger)
        {
            return true;
        }
    }
}
