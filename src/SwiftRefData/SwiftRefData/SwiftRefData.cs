using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SwiftRefData.Models;

namespace SwiftRefData
{
    public class SwiftRefData
        : ISwiftRefData
    {
        public List<Bank> GetBanks(string country)
        {
            if (String.IsNullOrEmpty(country) || country.Length != 2)
                return null;

            string file = String.Format("data/country/{0}.json", country);
            var content = File.ReadAllText(file);
            List<Bank> banks = JsonConvert.DeserializeObject<List<Bank>>(content);
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
            throw new NotImplementedException();
        }

        public List<IbanFormat> GetIbanFormats()
        { 
            var content = File.ReadAllText("data/iban/data.json");
            List<IbanFormat> ibanFormats = JsonConvert.DeserializeObject<List<IbanFormat>>(content);
            return ibanFormats;
        }
    }
}
