using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwiftRefData;
using SwiftRefData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RefData refData = new RefData();

            List<Country> countries = refData.GetCountries();

            List<IbanFormat> ibanFormats = refData.GetIbanFormats();

            List<Currency> currencies = refData.GetCurrencies();

            CountryBank countryBank = refData.GetBanks("TR");
            List<Bank> banks = countryBank.Banks;

            Console.ReadLine();
        }
    }
}
