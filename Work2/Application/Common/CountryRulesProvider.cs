using System;

namespace Common
{
    public class CountryRulesProvider
    {
        public CountryRule GetCountryRule(CountryIso countryIso)
        {
            switch (countryIso)
            {
                case CountryIso.LT:
                {
                    return new CountryRule() { CountryIso = CountryIso.LT,Length= 8,PhoneNumberPrefix= "+370" };
                }
                case CountryIso.PL:
                {
                    return new CountryRule() {CountryIso = CountryIso.PL, Length  = 7, PhoneNumberPrefix = "+48" };
                }
                case CountryIso.GB:
                {
                    return new CountryRule() { CountryIso = CountryIso.GB, Length = 10, PhoneNumberPrefix = "+44"};
                }
                case CountryIso.NO:
                {
                    return new CountryRule() { CountryIso = CountryIso.NO,Length = 6,PhoneNumberPrefix = "+47" };
                }
                case CountryIso.DK:
                {
                    return new CountryRule() { CountryIso = CountryIso.DK,Length = 6, PhoneNumberPrefix = "+45" };
                }
                default:
                {
                    return new CountryRule() { CountryIso = CountryIso.LT, Length = 8, PhoneNumberPrefix = "+370" };
                }
            }
        }
    }
}
