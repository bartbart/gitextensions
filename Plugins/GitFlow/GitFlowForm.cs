using System;
using System.Windows.Forms;
using GitFlow.UiControls;
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
            //UiControls.GitFlowInitForm initForm = new UiControls.GitFlowInitForm(_commander);
            //initForm.ShowDialog();

            InitUserControl initUc = new InitUserControl();

            groupBoxAction.Text = "Init";
            panelAction.Controls.Clear();
            panelAction.Controls.Add(initUc);

        }
    }
}
