using System.Collections.Generic;
using System.Windows.Forms;
using GitFlow.GitFlowCommands;

namespace GitFlow.UiControls
{
    public delegate void UiChangedHandler(IActionUserControl owner);

    public interface IActionUserControl
    {
        string Title { get; }

        bool CanExecute { get; }

        List<ICommand> Commands { get; }

        UserControl UserControl { get; }

        event UiChangedHandler OnUiChanged;
    }
}
