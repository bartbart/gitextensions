using System.Collections.Generic;
using System.Windows.Forms;
using GitFlow.GitFlowCommands;

namespace GitFlow.UiControls
{
    public partial class InitUserControl : UserControl, IActionUserControl
    {
        public InitUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return "Init"; }
        }

        public bool CanExecute
        {
            get { return checkBoxDefaults.Checked && checkBoxForce.Checked; }
        }

        public List<ICommand> Commands
        {
            get{ return new List<ICommand>(); }
        }

        public UserControl UserControl
        {
            get { return this; }
        }

        public event UiChangedHandler OnUiChanged;

        private void NotifyUiChanged(object sender, System.EventArgs e)
        {
            OnUiChanged(this);
        }
    }
}
