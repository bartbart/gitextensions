﻿namespace GitFlow.Commands.Impl
{
    class Or : Check
    {
        public override bool IndentLogging
        {
            get { return true; }
        }

        public override string Description
        {
            get
            {
                return string.Format("Is either \"{0}\" or \"{1}\" true.", Check1.Description, Check2.Description);
            }
        }

        public Check Check1 { get; set; }

        public Check Check2 { get; set; }

        protected override CheckResult RunCheck(IGit git, ILogger logger)
        {
            CheckResult result1 = Check1.Execute(git, logger);

            if (result1 == CheckResult.Failed)
            {
                return CheckResult.Failed;
            }

            if (result1 == CheckResult.True)
            {
                return CheckResult.True;
            }

            return Check2.Execute(git, logger);
        }
    }
}