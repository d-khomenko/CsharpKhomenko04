using System;
using Lab04Khomenko.Exceptions;
using Lab04Khomenko.Navigation;

namespace Lab04Khomenko.Model
{
    class AddUserModel
    {
        private readonly Storage _storage;

        public AddUserModel(Storage storage)
        {
            _storage = storage;
        }

        public void GoToMain()
        {
            NavigationManager.Instance.Navigate(ModesEnum.Main);
        }

        public void AddUser(string name, string surname, string email, DateTime date)
        {
            ValidateData(email, date);

            var user = new User(name, surname, email, date);
            _storage.AddUser(user);

            NavigationManager.Instance.Navigate(ModesEnum.Main);
        }

        private void ValidateData(string email, DateTime date)
        {
            var age = CalculateAge(date);

            if (age < 0)
                throw new FutureBirthdayException(date);
            if (age >= 135)
                throw new DistantPastBirthdayException(date);

            try
            {
                var _ = new System.Net.Mail.MailAddress(email);
            }
            catch (FormatException)
            {
                throw new InvalidEmailException(email);
            }
        }

        private int CalculateAge(DateTime dateTime)
        {
            var age = DateTime.Today.Date.Year - dateTime.Date.Year;
            if (dateTime > DateTime.Today.AddYears(-age))
                age--;
            return age;
        }
    }
}
