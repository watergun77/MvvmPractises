using System;
using System.Threading;
using System.Threading.Tasks;

namespace ToskersCorner.RelayCommand.Models
{
    public class CoffeeService : ObservableObject
    {
        private string connectionStatus;
        public string ConnectionStatus
        {
            get
            {
                return connectionStatus;
            }
            set
            {
                connectionStatus = value;
                OnPropertyChanged("ConnectionStatus");
            }
        }
        public CoffeeService()
        {
            IsExecuting = false;
            ConnectionStatus = "Connect";
        }
        public bool IsExecuting { get; set; }
        public async Task PrepareCoffeeAsync()
        {
            IsExecuting = true;
            Console.WriteLine("Async : Start making coffee");
            await Task.Run(() => Thread.Sleep(5000));            
            Console.WriteLine("Async : Done making coffee");
            IsExecuting = false;           
        }

        public void PrepareCoffee()
        {
            IsExecuting = true;
            Console.WriteLine("Start making coffee");
            Thread.Sleep(5000);
            Console.WriteLine("Done making coffee");
            IsExecuting = false;
        }
    }
}
