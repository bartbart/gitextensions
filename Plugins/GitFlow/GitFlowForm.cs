using System;
using System.Windows.Forms;
using GitUIPluginInterfaces;
using GitFlow.GitFlowCommands;

namespace GitFlow
{
    public partial class GitFlowForm : Form
    {
        private readonly GitFlowCommander _commander;

        public GitFlowForm(GitUIBaseEventArgs gitUiCommands)
        {
            _commander = new GitFlowCommander(gitUiCommands.GitModule);

            InitializeComponent();
        }

        private void OnButtonInitClicked(object sender, EventArgs e)
        {
            UiControls.GitFlowInitForm initForm = new UiControls.GitFlowInitForm(_commander);
            initForm.ShowDialog();
            //string result = gitUiCommands.GitCommands.RunGit("rev-parse --quiet --verify HEAD");
        }
    }
}
