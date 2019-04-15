using Lab04Khomenko.Tools;
using Newtonsoft.Json;
using System;
using static Lab04Khomenko.Model.ZodiacEnums;

namespace Lab04Khomenko.Model
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; }
        public DateTime BirthdayDate { get; }

        public string SunSign { get; }
        public string ChineseSign { get; }

        [JsonConstructor]
        public User(string name, string surname, string email, DateTime birthdayDate)
        {
            Name = name;
            Surname = surname;
            Email = email;
            BirthdayDate = birthdayDate;

            SunSign = FindWestZodiac(BirthdayDate);
            ChineseSign = FindChineseZodiac(BirthdayDate.Year);
        }

        public User(string name, string surname, DateTime birthdayDate)
        {
            Name = name;
            Surname = surname;
            BirthdayDate = birthdayDate;

            SunSign = FindWestZodiac(BirthdayDate);
            ChineseSign = FindChineseZodiac(BirthdayDate.Year);
        }

        public User(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;

            SunSign = FindWestZodiac(BirthdayDate);
            ChineseSign = FindChineseZodiac(BirthdayDate.Year);
        }

        public bool IsAdult
        {
            get
            {
                var age = DateTime.Today.Date.Year - BirthdayDate.Date.Year;
                if (BirthdayDate > DateTime.Today.AddYears(-age))
                    age--;

                return (age >= 18);
            }
        }

        public bool IsBirthday
        {
            get
            {
                return BirthdayDate.DayOfYear == DateTime.Today.DayOfYear;
            }
        }

        private string FindWestZodiac(DateTime date)
        {
            var day = date.Day;
            var month = date.Month;

            switch (month)
            {
                case 3 when day >= 21:
                case 4 when day <= 20:
                    return ZodiacEnums.WestZodiac.Aries.GetDescription();
                case 4 when day >= 21:
                case 5 when day <= 20:
                    return ZodiacEnums.WestZodiac.Taurus.GetDescription();
                case 5 when day >= 21:
                case 6 when day <= 21:
                    return ZodiacEnums.WestZodiac.Gemini.GetDescription();
                case 6 when day >= 22:
                case 7 when day <= 22:
                    return ZodiacEnums.WestZodiac.Canser.GetDescription();
                case 7 when day >= 23:
                case 8 when day <= 23:
                    return ZodiacEnums.WestZodiac.Leo.GetDescription();
                case 8 when day >= 24:
                case 9 when day <= 23:
                    return ZodiacEnums.WestZodiac.Virgo.GetDescription();
                case 9 when day >= 24:
                case 10 when day <= 22:
                    return ZodiacEnums.WestZodiac.Libra.GetDescription();
                case 10 when day >= 23:
                case 11 when day <= 22:
                    return ZodiacEnums.WestZodiac.Scorpio.GetDescription();
                case 11 when day >= 23:
                case 12 when day <= 21:
                    return ZodiacEnums.WestZodiac.Sagittarius.GetDescription();
                case 12 when day >= 22:
                case 1 when day <= 20:
                    return ZodiacEnums.WestZodiac.Capricorn.GetDescription();
                case 1 when day >= 21:
                case 2 when day <= 19:
                    return ZodiacEnums.WestZodiac.Aquarius.GetDescription();
                case 2 when day >= 20:
                case 3 when day <= 20:
                    return ZodiacEnums.WestZodiac.Pisces.GetDescription();
                default:
                    return "Упсс, щось пішло не так!";
            }
        }

        private string FindChineseZodiac(int year)
        {
            var modY = year % 12;
            return ((ZodiacEnums.ChineseZodiac)modY).GetDescription();
        }
    }
}
