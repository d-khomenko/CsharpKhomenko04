using System;

namespace Lab04Khomenko.Exceptions
{
    class FutureBirthdayException : Exception
    {
        public FutureBirthdayException(DateTime birthDate)
            : base($"birthDate>currentDate\nНекоректна дата - {birthDate:dd.MM.yyy}")
        { }
    }
}
