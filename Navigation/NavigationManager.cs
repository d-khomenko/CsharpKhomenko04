using Lab04Khomenko.Model;

namespace Lab04Khomenko.Navigation
{
    class NavigationManager
    {
        private static NavigationManager _instance;
        private static readonly object _lock = new object();
        private NavigationModel _navigationModel;

        public static NavigationManager Instance
        {
            get
            {
                if (_instance != null) return _instance;
                {
                    lock (_lock)
                    {
                        _instance = new NavigationManager();
                    }
                }
                return _instance;
            }
        }

        public void Initialize(NavigationModel navigationModel)
        {
            _navigationModel = navigationModel;
        }

        public void Navigate(ModesEnum mode)
        {
            _navigationModel?.Navigate(mode);
        }
    }
}
