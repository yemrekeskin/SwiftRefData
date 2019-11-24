using SwiftRefData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftRefData
{
    public interface ISwiftRefData
    {
        List<Country> GetCountries();
        List<Bank> GetBanks(string country);
        List<Currency> GetCurrencies();
        List<IbanFormat> GetIbanFormats();
    }
}
