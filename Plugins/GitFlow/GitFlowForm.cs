using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GitUIPluginInterfaces;
using GitFlow.GitFlowCommands;

namespace GitFlow
{
    public partial class GitFlowForm : Form
    {
        private readonly GitUIBaseEventArgs gitUiCommands;
        private readonly GitFlowCommander commander;

        public GitFlowForm(GitUIBaseEventArgs gitUiCommands)
        {
            this.gitUiCommands = gitUiCommands;

            this.commander = new GitFlowCommander(gitUiCommands.GitCommands);

            InitializeComponent();
        }

        private void OnButtonInitClicked(object sender, EventArgs e)
        {
            UiControls.GitFlowInitForm initForm = new UiControls.GitFlowInitForm(commander);
            initForm.ShowDialog();
            //string result = gitUiCommands.GitCommands.RunGit("rev-parse --quiet --verify HEAD");
        }
    }
}
