using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftRefData.Models
{
    public class Currency
    {
        public string CountryName { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string MinorUnit { get; set; }
    }
}
