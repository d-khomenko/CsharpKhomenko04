using System.Windows;
using Lab04Khomenko.Model;
using Lab04Khomenko.Navigation;
using Lab04Khomenko.Windows;

namespace Lab04Khomenko
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Storage storage = new Storage();
            ContentWindow contentWindow = new ContentWindow();

            NavigationModel navigationModel = new NavigationModel(contentWindow, storage);
            NavigationManager.Instance.Initialize(navigationModel);
            contentWindow.Show();
            navigationModel.Navigate(ModesEnum.Main);
        }
    }
}
