using System.Collections.Generic;
using System.Windows.Forms;
using GitFlow.Commands;
using GitFlow.Commands.Builder;

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
            get { return true; }
        }

        public Command Command
        {
            get
            {
                Builder builder = new Builder();

                InitInput input = new InitInput();
                input.UseDefaults = checkBoxDefaults.Checked;
                input.Force = checkBoxForce.Checked;

                return builder.From(input);
            }
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
