<img src="https://github.com/yemrekeskin/SwiftRefData/blob/master/refdata.png" width="50" height="50"> 

# Swift Reference Data

- List of country codes as defined by ISO 3166
- List of currency codes as defined by ISO 4217
- BIC - Business Instutition Codes by country code
- IBAN Formats by country code

# Usage

```CSharp
RefData refData = new RefData();

List<Country> countries = refData.GetCountries();

List<IbanFormat> ibanFormats = refData.GetIbanFormats();

List<Currency> currencies = refData.GetCurrencies();

CountryBank countryBank = refData.GetBanks("TR");
List<Bank> banks = countryBank.Banks;
```

## Contribution
Pull requests are welcome, but make sure you sign the Contributor License Agreement.

## License

SwiftRefData is licensed under the MIT license. Check the [LICENSE](LICENSE) file for details.
