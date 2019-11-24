using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftRefData.Models
{
    public class IbanFormat
    {
        public string Country { get; set; }
        public string Length { get; set; }
        public string Code { get; set; }
        public string Format { get; set; }
    }
}
