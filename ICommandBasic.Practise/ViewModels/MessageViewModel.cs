using ICommandBasic.Practise.ViewModels.Commands;
using System.Windows;

namespace ICommandBasic.Practise.ViewModels
{
    public class MessageViewModel
    {
        public MessageCommand MessageCommand { get; private set; }

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
