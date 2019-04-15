using System;
using Lab04Khomenko.Views;
using Lab04Khomenko.Windows;

namespace Lab04Khomenko.Model
{
    public enum ModesEnum
    {
        Main,
        AddUser,
        EditUser
    }

    class NavigationModel
    {
        private readonly ContentWindow _contentWindow;
        private readonly MainView _mainView;
        private readonly AddUserView _addUserView;
        private readonly EditUserView _editUserView;

        public NavigationModel(ContentWindow contentWindow, Storage storage)
        {
            _contentWindow = contentWindow;
            _mainView = new MainView(storage);
            _addUserView = new AddUserView(storage);
            _editUserView = new EditUserView(storage);
        }

        public void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Main:
                    _contentWindow.ContentControl.Content = _mainView;
                    break;
                case ModesEnum.AddUser:
                    _contentWindow.ContentControl.Content = _addUserView;
                    break;
                case ModesEnum.EditUser:
                    _contentWindow.ContentControl.Content = _editUserView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}
