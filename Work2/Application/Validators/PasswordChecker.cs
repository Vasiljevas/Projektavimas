using System;

namespace Validator
{
    public class PasswordChecker
    {
        public bool LongerThan(string password, int x)
        {
            return password.Length() >= x;
        }

        public bool ContainsUppercase(string password)
        {
            return password.Any(c => char.IsUpper(c));
        }

        public bool ContainsSpecialCharacter(string password)
        {
            return password.Any(c => !Char.IsLetterOrDigit(ch));
        }
    }
}
