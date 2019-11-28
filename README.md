<img src="https://github.com/yemrekeskin/SwiftRefData/blob/master/refdata.png" width="50" height="50"> 

# Swift Reference Data

This project providers the list of reference data like country, currency, banks and iban formats related to swift (fin messaging system). Data formats based json

- List of country codes as defined by [**ISO 3166**](https://www.iso.org/iso-3166-country-codes.html)
  - Country Name: Turkey
  - Alpha2 Code: TR
  - Alpha3 Code: TUR
  - Country Code: 792  
- List of currency codes as defined by [**ISO 4217**](https://www.iso.org/iso-4217-currency-codes.html)
  - Country Name : TURKEY
  - Name : Turkish Lira
  - Alphabetic Code : TRY
  - Number Code : 949
  - Minor Unit : 2
- BIC - Business Identifier Codes by [**ISO 9362**](https://www.iso.org/standard/60390.html)
  - Bank : DENIZBANK A.S.
  - City : ISTANBUL
  - Branch : null
  - Swift Code : DENITRIS
- IBAN Formats by country code
  - Country : Turkey
  - Length : 26
  - Code : TR
  - Format (FIN type charset) : TR2!n5!n1!c16!c

# Usage

```CSharp
RefData refData = new RefData();

List<Country> countries = refData.GetCountries();

List<IbanFormat> ibanFormats = refData.GetIbanFormats();

List<Currency> currencies = refData.GetCurrencies();

CountryBank countryBank = refData.GetBanks("TR");
List<Bank> banks = countryBank.Banks;
```

## TODO
- List of SWIFT Message Type
  - Category - MT1XX
  - Category Description - Customer Payments and Cheques For Standards MT
    - Message Type (MT Name) - 103
    - Identifier - fin.103 fin.103.REMIT fin.103.STP
    - Name - Single Customer Credit Transfer
    - Purpose - Instructs a funds transfer
    - Max Length - 10,000

## Useful Links
- [Swift General Information](https://www2.swift.com/knowledgecentre/publications/usgi/2.0)

## Contribution
Pull requests are welcome, but make sure you sign the Contributor License Agreement.

## License

SwiftRefData is licensed under the MIT license. Check the [LICENSE](LICENSE) file for details.
