using System.Windows.Controls;
using Lab04Khomenko.Model;
using Lab04Khomenko.ViewModels;

namespace Lab04Khomenko.Views
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUserView : UserControl
    {
        public EditUserView(Storage storage)
        {
            InitializeComponent();

            EditUserViewModel viewModel = new EditUserViewModel(storage);
            DataContext = viewModel;
        }
    }
}
