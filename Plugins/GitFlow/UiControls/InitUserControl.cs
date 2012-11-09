using System.Windows.Forms;

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

        public UserControl UserControl
        {
            get { return this; }
        }

        public event UiChangedHandler OnUiChanged;

        private void CheckBoxDefaultsCheckedChanged(object sender, System.EventArgs e)
        {
            OnUiChanged(this);
        }

        private void CheckBoxForceCheckedChanged(object sender, System.EventArgs e)
        {
            OnUiChanged(this);
        }
    }
}
