using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwiftRefData;
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

            var countries = refData.GetCountries();

            var ibanFormats = refData.GetIbanFormats();

            var currencies = refData.GetCurrencies();

            var countryBank = refData.GetBanks("tr");
            var banks = countryBank.Banks;

            Console.ReadLine();
        }
    }
}
