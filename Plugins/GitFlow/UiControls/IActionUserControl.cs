using System.Windows.Forms;

namespace GitFlow.UiControls
{
    public delegate void UiChangedHandler(IActionUserControl owner);

    public interface IActionUserControl
    {
        string Title { get; }

        bool CanExecute { get; }

        UserControl UserControl { get; }

        event UiChangedHandler OnUiChanged;
    }
}
