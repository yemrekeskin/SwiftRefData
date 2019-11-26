using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SwiftRefData.Models;

namespace SwiftRefData
{
    public interface IRefData
    {
        List<Country> GetCountries();
        CountryBank GetBanks(string country);
        List<Currency> GetCurrencies();
        List<IbanFormat> GetIbanFormats();
    }

    public class RefData
        : IRefData
    {
        public CountryBank GetBanks(string country)
        {
            if (String.IsNullOrEmpty(country) || country.Length != 2)
                return null;

            string file = String.Format("data/bic/{0}.json", country.ToUpper());
            var content = File.ReadAllText(file);
            CountryBank banks = JsonConvert.DeserializeObject<CountryBank>(content);
            return banks;
        }

        public List<Country> GetCountries()
        {
            var content = File.ReadAllText("data/country/data.json");
            List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(content);
            return countries;
        }

        public List<Currency> GetCurrencies()
        {
            var content = File.ReadAllText("data/currency/data.json");
            List<Currency> currencies = JsonConvert.DeserializeObject<List<Currency>>(content);
            return currencies;
        }

        public List<IbanFormat> GetIbanFormats()
        { 
            var content = File.ReadAllText("data/iban/data.json");
            List<IbanFormat> ibanFormats = JsonConvert.DeserializeObject<List<IbanFormat>>(content);
            return ibanFormats;
        }
    }
}
