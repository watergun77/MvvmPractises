using System.Windows;
using ToskersCorner.ViewModels.Commands;

namespace ToskersCorner.ViewModels
{
    public class MessageViewModel
    {
        public MessageCommand DisplayMessageCommand { get; private set; }

        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }
        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
