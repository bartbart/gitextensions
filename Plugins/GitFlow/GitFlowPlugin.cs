using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitUIPluginInterfaces;

namespace GitFlow
{
    public class GitFlowPlugin : IGitPluginForRepository
    {
        public string Description
        {
            get { return "Git flow"; }
        }

        public IGitPluginSettingsContainer Settings { get; set; }

        public void Register(IGitUICommands gitUiCommands)
        {
            //Settings.AddSetting("Find large files bigger than (Mb)", "1");
        }

        public bool Execute(GitUIBaseEventArgs gitUiCommands)
        {
            return true;
        }
    }
}
