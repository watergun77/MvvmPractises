using ICommandBasic.Practise.ViewModels;
using System.Windows;

namespace ICommandBasic.Practise
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
