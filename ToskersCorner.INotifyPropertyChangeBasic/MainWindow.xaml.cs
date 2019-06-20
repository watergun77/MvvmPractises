using System.Windows;
using ToskersCorner.INotifyPropertyChangeBasic.ViewModels;

namespace ToskersCorner.INotifyPropertyChangeBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}
