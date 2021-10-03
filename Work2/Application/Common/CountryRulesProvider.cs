using System;

namespace Common
{
    public class CountryRulesProvider
    {
        public CountryRule GetCountryRule(CountryIso countryIso)
        {
            switch (countryIso)
            {
                case countryIso.LT:
                {
                    return new CountryRule(countryIso.LT, 8, "+370");
                }
                case countryIso.PL:
                {
                    return new CountryRule(countryIso.PL, 7, "+48");
                }
                case countryIso.GB:
                {
                    return new CountryRule(countryIso.GB, 10, "+44");
                }
                case countryIso.NO:
                {
                    return new CountryRule(countrIso.NO, 6, "+47");
                }
                case countryIso.DK:
                {
                    return new CountryRule(countrIso.DK, 6, "+45");
                }
                default:
                {
                    return new CountryRule(countrIso.LT, 8, "+370");
                }
            }
        }
    }
}
