using DelegateCommand_Practises.Models;

namespace DelegateCommand_Practises.ViewModels
{
    class ViewModel
    {
        public Model Model { get; set; }
        public DelegateCommand ConnectCommand { get; set; }
        private bool isExecuting;
        private bool IsExecuting
        {
            get { return isExecuting; }
            set
            {
                isExecuting = value;
                ConnectCommand.RaiseCanExecuteChanged();
            }
        }

        public ViewModel()
        {
            Model = new Model();
            ConnectCommand = new DelegateCommand(ExecuteCommand, CanExecuteCommand);
            IsExecuting = false;
        }

        private bool CanExecuteCommand(object obj)
        {
            return !IsExecuting;
        }

        private async void ExecuteCommand(object obj)
        {
            IsExecuting = true;
            await Model.Connect();
            IsExecuting = false;
        }
    }
}
