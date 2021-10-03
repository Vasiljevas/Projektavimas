using Common;
using System;

namespace Validators
{
    public class PhoneValidator
    {
        public bool ContainsOnlyNumbers(string phoneNumber)
        {
            foreach(char c in phoneNumber)
            {
                if(c < '0' || c > '9')
                {
                    return false;
                }
                return true;
            }
        }

        // Breaks SOLID
        // As Validator should be responsible only for validation
        public string ConvertToInternationalPhoneNumber(string phoneNumber)
        {
            char first = phoneNumber[0];
            CountryRule rule = new CountryRule();
            if(phoneNumber[0] == '8')
            {
                rule = CountryRulesProvider.GetCountryRule(CountryIso.LT);
                string trimmed = phoneNumber.Substring(1);
                return rule.PhoneNumberPrefix + trimmed;
            }
            else if(phoneNumber.StartsWith("07"))
            {
                rule = CountryRulesProvider.GetCountryRule(CountryIso.GB);
                string trimmed = phoneNumber.Substring(2);
                return rule.PhoneNumberPrefix + trimmed;
            }
            else if(phoneNumber.StartsWith("+47"))
            {
                return phoneNumber;
            }
            else if(phoneNumber.StartsWith("+45"))
            {
                return phoneNumber;
            }
            else
            {
                return phoneNumber;
            }
        }

        public bool IsValidInCountry(string phoneNumber, CountryIso countryIso)
        {
            rule = CountryRulesProvider.GetCountryRule(countryIso);
            return (phoneNumber.length() === rule.Length && phoneNumber.StartsWith(rule.PhoneNumberPrefix));
        }
    }
}
