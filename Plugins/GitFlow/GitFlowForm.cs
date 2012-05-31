using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GitUIPluginInterfaces;

namespace GitFlow
{
    public partial class GitFlowForm : Form
    {
        private readonly GitUIBaseEventArgs gitUiCommands;
        private readonly IGitCommands gitCommands;

        public GitFlowForm(GitUIBaseEventArgs gitUiCommands)
        {
            this.gitUiCommands = gitUiCommands;
            this.gitCommands = gitUiCommands.GitCommands;

            InitializeComponent();
        }

        private void OnButtonInitClicked(object sender, EventArgs e)
        {
            string result = gitUiCommands.GitCommands.RunGit("rev-parse --quiet --verify HEAD");
        }
    }
}
