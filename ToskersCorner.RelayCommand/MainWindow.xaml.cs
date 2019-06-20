using System.Windows;
using ToskersCorner.RelayCommand.ViewModels;

namespace ToskersCorner.RelayCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MessageViewModel();
        }
    }
}
