using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftRefData.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public string CountryCode { get; set; }
        public string Iso3166_2 { get; set; }

        public string IntermediateRegion { get; set; }
        public int IntermediateRegionCode { get; set; }

        public string Region { get; set; }
        public string RegionCode { get; set; }

        public string SubRegion { get; set; }        
        public string SubRegionCode { get; set; }        
    }
}
