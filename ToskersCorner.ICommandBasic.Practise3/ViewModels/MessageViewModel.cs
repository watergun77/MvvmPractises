using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToskersCorner.ICommandBasic.Practise3.ViewModels.Commands;

namespace ToskersCorner.ICommandBasic.Practise3.ViewModels
{
    class MessageViewModel
    {
        public MessageCommand MessageCommand { get; set; }

        public MessageViewModel()
        {
            MessageCommand = new MessageCommand(DisplayMessage);
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
