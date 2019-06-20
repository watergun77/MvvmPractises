using System;
using System.Windows.Input;

namespace Eduardo.Rosas.ViewModels.Commands
{
    public class SimpleCommand : ICommand
    {
        public ViewModelBase ViewModel { get; set; }

        public SimpleCommand(ViewModelBase viewModel)
        {
            ViewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.SimpleMethod();
        }
    }
}
