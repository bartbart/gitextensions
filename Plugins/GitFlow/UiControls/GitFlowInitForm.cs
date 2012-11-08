using System;
using System.Windows.Forms;
using GitFlow.GitFlowCommands;

namespace GitFlow.UiControls
{
    internal partial class GitFlowInitForm : Form
    {
        private readonly GitFlowCommander _commander;

        public GitFlowInitForm(GitFlowCommander commander)
        {
            _commander = commander;

            InitializeComponent();
        }

        private void OnButtonCancelClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void OnButtonOkClicked(object sender, EventArgs e)
        {
            try
            {
                RunGitInitCommand();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
            Close();
        }

        private void RunGitInitCommand()
        {
            if (!_commander.IsGitRepo)
            {
                _commander.ExecuteGitInit();
            }
            else
            {
                if (!_commander.IsGitRepoHeadless)
                {
                    _commander.RequireCleanWorkingTree();
                }
            }
        }
    }
}
