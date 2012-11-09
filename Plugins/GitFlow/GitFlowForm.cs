using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GitFlow.Commands;
using GitFlow.UiControls;
using GitUIPluginInterfaces;

namespace GitFlow
{
    public partial class GitFlowForm : Form
    {
        private IGitModule _gitModule;

        private IActionUserControl _actionUserControl;

        public GitFlowForm(GitUIBaseEventArgs gitUiCommands)
        {
            _gitModule = gitUiCommands.GitModule;

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

            List<ICommand> commands = _actionUserControl.Commands;
            foreach (ICommand command in commands)
            {
                command.Execute(new Git(_gitModule), new Logger(LogLine));
            }
        }

        private void LogLine(string arguments)
        {
            textBoxLogging.Text += arguments + Environment.NewLine;
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
