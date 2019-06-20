using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ToskersCorner.RelayCommand.ViewModels
{
    public class MessageViewModel
    {
        public ObservableCollection<string> MyMessages { get; private set; }
        public RelayCommand MessageBoxCommand { get; private set; }
        public RelayCommand ConsoleLogCommand { get; private set; }

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
        }

        //private bool IsEnable { get; set; } = true;
        //public async void DisplayInMessageBox(object message)
        public void DisplayInMessageBox(object message)
        {
            //IsEnable = false;
            MessageBox.Show((string)message);
            //await Task.Run(()=>Thread.Sleep(5000));
            //await Task.Run(() => MessageBox.Show((string)message));
            //IsEnable = true;
        }

        public void DisplayInConsole(object message)
        {
            Console.WriteLine((string)message);
        }

        public bool MessageBoxCanUse(object message)
        {
            if ((string)message == "Im a console!")
                return false;

            return true;
            //return IsEnable;
        }

        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "Im a message box!")
                return false;

            return true;
        }
    }
}
