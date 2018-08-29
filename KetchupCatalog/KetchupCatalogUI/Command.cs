﻿using System;
using System.Windows.Input;

namespace Gorny.KetchupCatalog.KetchupCatalogUI
{
    class Command : ICommand
    {
        private readonly Action<object> _action;
        public Command(Action<object> action)
        {
            _action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
