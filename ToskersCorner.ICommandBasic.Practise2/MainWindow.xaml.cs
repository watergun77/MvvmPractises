using System.Windows;
using ToskersCorner.ICommandBasic.Practise2.ViewModels;

namespace ToskersCorner.ICommandBasic.Practise2
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
