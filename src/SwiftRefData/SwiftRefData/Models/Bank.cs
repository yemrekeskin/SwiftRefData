using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftRefData.Models
{
    public class Bank
    {
        [JsonProperty("swift_code")]
        public string Bic { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("branch")]
        public string Branch { get; set; }
        [JsonProperty("bank")]
        public string BankName { get; set; }
    }
}