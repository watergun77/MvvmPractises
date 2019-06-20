using System;
using System.Windows.Input;

namespace Eduardo.Rosas.ViewModels.Commands
{
    public class ParameterCommand : ICommand
    {
        public ViewModelBase ViewModel { get; set; }

        public ParameterCommand(ViewModelBase viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if(parameter != null)
            {
                var s = parameter as string;
                s = s.Trim();
                if (string.IsNullOrEmpty(s))
                    return false;
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            ViewModel.ParameterMethod(parameter as string);
        }
    }
}
