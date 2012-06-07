using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GitFlow.GitFlowCommands;

namespace GitFlow.UiControls
{
    internal partial class GitFlowInitForm : Form
    {
        private readonly GitFlowCommander commander;

        public GitFlowInitForm(GitFlowCommander commander)
        {
            this.commander = commander;

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
            if (!commander.IsGitRepo)
            {
                commander.ExecuteGitInit();
            }
            else
            {
                if (!commander.IsGitRepoHeadless)
                {
                    commander.RequireCleanWorkingTree();
                }
            }
        }
    }
}
