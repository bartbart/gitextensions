﻿using System.Collections.Generic;
using System.Windows.Forms;
using GitFlow.Commands;

namespace GitFlow.UiControls
{
    public delegate void UiChangedHandler(IActionUserControl owner);

    public interface IActionUserControl
    {
        string Title { get; }

        bool CanExecute { get; }

        Command Command { get; }

        UserControl UserControl { get; }

        event UiChangedHandler OnUiChanged;
    }
}