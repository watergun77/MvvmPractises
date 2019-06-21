using DelegateCommand_Practises.ViewModels;
using System.Windows;

namespace DelegateCommand_Practises.Views
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}
