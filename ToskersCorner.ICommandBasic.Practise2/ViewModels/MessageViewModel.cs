using System.Windows;
using ToskersCorner.ICommandBasic.Practise2.ViewModels.Commands;

namespace ToskersCorner.ICommandBasic.Practise2.ViewModels
{
    public class MessageViewModel
    {
        public MessageCommand MessageCommand { get; set; }

        public MessageViewModel()
        {
            MessageCommand = new MessageCommand(ShowMessage);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
