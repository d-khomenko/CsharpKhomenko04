using System.Windows.Controls;
using Lab04Khomenko.Model;
using Lab04Khomenko.ViewModels;

namespace Lab04Khomenko.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView(Storage storage)
        {
            InitializeComponent();

            MainViewModel viewModel = new MainViewModel(storage);
            DataContext = viewModel;
        }
    }
}
