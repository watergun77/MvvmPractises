using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using ToskersCorner.RelayCommand.Models;

namespace ToskersCorner.RelayCommand.ViewModels
{
    public class MessageViewModel
    {
        public ObservableCollection<string> MyMessages { get; private set; }
        public RelayCommand MessageBoxCommand { get; private set; }        
        public RelayCommand ConsoleLogCommand { get; private set; }
        public RelayCommand SubmitAsync { get; private set; }
        public RelayCommand Submit { get; private set; }
        CoffeeService coffeeService { get; set; }
        public MessageViewModel()
        {
            MyMessages = new ObservableCollection<string>()
            {
                "Hello World!",
                "My name is Joe",
                "I love learning commands",
                "Im a message box!",
                "Im a console!"
            };

            MessageBoxCommand = new RelayCommand(DisplayInMessageBox, MessageBoxCanUse);
            ConsoleLogCommand = new RelayCommand(DisplayInConsole, ConsoleCanUse);

            coffeeService = new CoffeeService();
            SubmitAsync = new RelayCommand(ExecuteSubmitAsync, CanExecuteSubmit);
            Submit = new RelayCommand(ExecuteSubmit, CanExecuteSubmit);
        }
        
        public void DisplayInMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }
        public bool MessageBoxCanUse(object message)
        {
            if ((string)message == "Im a console!")
                return false;

            return true;
        }
        public void DisplayInConsole(object message)
        {
            Console.WriteLine((string)message);
        }
        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "Im a message box!")
                return false;

            return true;
        }        

        private async void ExecuteSubmitAsync(object message)
        {
            await coffeeService.PrepareCoffeeAsync();            
            CommandManager.InvalidateRequerySuggested(); // Refresh button from disable to enable
        }

        private void ExecuteSubmit(object message)
        {
            coffeeService.PrepareCoffee();
        }

        private bool CanExecuteSubmit(object message)
        {
            return !coffeeService.IsExecuting;
        }
    }
}
