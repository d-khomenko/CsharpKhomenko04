using System;

namespace Lab04Khomenko.Exceptions
{
    class DistantPastBirthdayException : Exception
    {
        public DistantPastBirthdayException(DateTime birthDate)
            : base($"Точно ?\nНекоректна дата - {birthDate:dd.MM.yyy}")
        { }
    }
}
