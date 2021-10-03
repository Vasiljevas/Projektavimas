using System;
using Common;

namespace Validators
{
    public class EmailValidator
    {
        // Cannot start or end with @
        // Appears only once
        public bool IsValidAtSign(string email)
        {
            CharCounter func = new CharCounter();
            int numberOfChars = func.CountChars(email, '@');
            if(numberOfChars != 1 || email.StartsWith('@') || email.EndsWith('@'))  
            {
                return false;
            }
            return true;
        }

        // uppercase and lowercase Latin letters A to Z and a to z
        // digits 0 to 9
        // printable characters !#$%&'*+-/=?^_`{|}~
        // dot., provided that it is not the first or last character and provided also that it does not appear consecutively(e.g., John..Doe @example.com is not allowed)
        // after it @ should follow
        public bool IsValidLocalPart(string email)
        {
            if(email.Length < 2)
            {
                return false;
            }
            if(email.StartsWith('.') || email.EndsWith('.'))
            {
                return false;
            }
            for(int i = 0; i < email.Length; i++)
            {
                if(i != 0)
                {
                    if(email[i] == '.' && email[i-1] == '.')
                    {
                        return false;
                    }
                }
            }
            if(!email.EndsWith("@"))
            {
                return false;
            }
            return true;
        }

        // uppercase and lowercase Latin letters A to Z and a to z;
        // hyphen -, provided that it is not the first or last character.
        // should appear after @
        public bool IsValidDomain(string email)
        {
            string[] subs = email.Split('@');
            string needed = subs[1];
            if(needed.Length < 2)
            {
                return false;
            }
            if(needed.Contains('@'))
            {
                return false;
            }
            if(!needed.Contains('.'))
            {
                return false;
            }
            return true;
        }

        // uppercase and lowercase Latin letters A to Z and a to z;
        // MUST be at least 2 characters long and MAY be as long as 63 characters
        public bool IsValidTopLevelDomain(string email)
        {
            if(email.Length == 0)
            {
                return false;
            }
            string[] subs = email.Split('@');
            string needed = subs[1].Split('.')[1];
            if(needed.Length < 2 || needed.Length > 63)
            {
                return false;
            }
            if(needed.Contains('@'))
            {
                return false;
            }
            foreach(char c in needed)
            {
                if(c >= '0' && c <= '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
