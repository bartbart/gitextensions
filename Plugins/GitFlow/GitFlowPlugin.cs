using System.Windows.Forms;
using GitUIPluginInterfaces;

namespace GitFlow
{
    public class GitFlowPlugin : GitPluginBase
    {
        public override string Description
        {
            get { return "Git flow"; }
        }

        public new IGitPluginSettingsContainer Settings { get; set; }

        public override bool Execute(GitUIBaseEventArgs gitUiCommands)
        {
            new GitFlowForm(gitUiCommands).ShowDialog(gitUiCommands.OwnerForm as IWin32Window);
            return true;
        }
    }
}
