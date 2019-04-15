using System;

namespace Lab04Khomenko.Exceptions
{
    class InvalidEmailException : Exception
    {
        public InvalidEmailException(string email)
            : base($"Некоректна пошта - {email}")
        { }
    }
}
