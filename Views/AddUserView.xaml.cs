using System.Windows.Controls;
using Lab04Khomenko.Model;
using Lab04Khomenko.ViewModels;

namespace Lab04Khomenko.Views
{
    /// <summary>
    /// Логика взаимодействия для AddUserView.xaml
    /// </summary>
    public partial class AddUserView : UserControl
    {
        public AddUserView(Storage storage)
        {
            InitializeComponent();

            AddUserViewModel viewModel = new AddUserViewModel(storage);
            DataContext = viewModel;
        }
    }
}
