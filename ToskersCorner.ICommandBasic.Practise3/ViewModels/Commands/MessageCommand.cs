﻿using System;
using System.Windows.Input;

namespace ToskersCorner.ICommandBasic.Practise3.ViewModels.Commands
{
    class MessageCommand : ICommand
    {
        private Action<string> _execute;
        public MessageCommand(Action<string> execute)
        {
            _execute = execute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter as string);
        }
    }
}
