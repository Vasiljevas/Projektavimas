using Common;
using System;

namespace Validators
{
    public class PhoneValidator
    {
        public bool ContainsOnlyNumbers(string phoneNumber)
        {
            if(phoneNumber == "")
            {
                return false;
            }
            foreach(char c in phoneNumber)
            {
                if(c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        // Breaks SOLID
        // As Validator should be responsible only for validation
        public string ConvertToInternationalPhoneNumber(string phoneNumber)
        {
            if(phoneNumber == "")
            {
                return phoneNumber;
            }
            CountryRulesProvider prov = new CountryRulesProvider();
            if(phoneNumber[0] == '8')
            {
                var rule = prov.GetCountryRule(CountryIso.LT);
                string trimmed = phoneNumber.Substring(1);
                return rule.PhoneNumberPrefix + trimmed;
            }
            else if(phoneNumber.StartsWith("07"))
            {
                var rule  = prov.GetCountryRule(CountryIso.GB);
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
            CountryRulesProvider prov = new CountryRulesProvider();
            var rule = prov.GetCountryRule(countryIso);
            return (phoneNumber.Length == rule.Length && phoneNumber.StartsWith(rule.PhoneNumberPrefix));
        }
    }
}
