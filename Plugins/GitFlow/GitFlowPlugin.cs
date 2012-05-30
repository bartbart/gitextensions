using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            new GitFlowForm(gitUiCommands).ShowDialog(gitUiCommands.OwnerForm as IWin32Window);
            return true;
        }
    }
}
