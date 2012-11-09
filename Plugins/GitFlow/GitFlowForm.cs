using System;
using System.Windows.Forms;
using GitFlow.Commands;
using GitFlow.UiControls;
using GitUIPluginInterfaces;

namespace GitFlow
{
    public partial class GitFlowForm : Form
    {
        private readonly GitFlowCommander _commander;

        private IActionUserControl _actionUserControl;

        public GitFlowForm(GitUIBaseEventArgs gitUiCommands)
        {
            _commander = new GitFlowCommander(gitUiCommands.GitModule);

            InitializeComponent();
        }

        private void SetAction(IActionUserControl action)
        {
            if (_actionUserControl != null)
            {
                _actionUserControl.OnUiChanged -= OnUiChanged;
            }

            _actionUserControl = action;

            groupBoxAction.Text = _actionUserControl.Title;

            panelAction.Controls.Clear();
            panelAction.Controls.Add(_actionUserControl.UserControl);

            _actionUserControl.OnUiChanged += OnUiChanged;
            OnUiChanged(_actionUserControl);
        }

        void OnUiChanged(IActionUserControl owner)
        {
            buttonExecute.Enabled = owner.CanExecute;
        }

        private void OnButtonInitClicked(object sender, EventArgs e)
        {
            SetAction(new InitUserControl());
        }

        private void ButtonExecuteClick(object sender, EventArgs e)
        {
            textBoxLogging.Clear();
        }

        private void GitFlowFormKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
