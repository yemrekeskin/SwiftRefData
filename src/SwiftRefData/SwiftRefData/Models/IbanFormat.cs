using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftRefData.Models
{
    public class IbanFormat
    {
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("length")]
        public string Length { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
    }
}
