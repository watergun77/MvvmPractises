using System;
using System.Threading;
using System.Threading.Tasks;

namespace ToskersCorner.RelayCommand.Models
{
    public class CoffeeService : ObservableObject
    {
        public CoffeeService()
        {
            isExecuting = false;
        }

        private bool isExecuting;
        public bool IsExecuting
        {
            get
            {
                return isExecuting;
            }
            set
            {                
                isExecuting = value;
                OnPropertyChanged("IsExecuting");
            }
        }
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
