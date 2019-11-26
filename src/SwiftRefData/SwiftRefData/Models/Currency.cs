using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftRefData.Models
{
    public class Currency
    {
        [JsonProperty("CtryNm")]
        public string CountryName { get; set; }

        [JsonProperty("CcyNm")]
        public string Name { get; set; }

        [JsonProperty("Ccy")]
        public string Code { get; set; }

        [JsonProperty("CcyNbr")]
        public string Number { get; set; }

        [JsonProperty("CcyMnrUnts")]
        public string MinorUnit { get; set; }
    }
}
