using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftRefData.Models
{
    public class Bank
    {
        public string Bic { get; set; }

        public string City { get; set; }
        public string Branch { get; set; } 
        public string BankName { get; set; }
    }
}