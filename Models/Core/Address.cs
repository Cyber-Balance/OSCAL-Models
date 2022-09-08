using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class Address
    {
        public Address()
        {
            AddrLines = new List<string>();
        }

        public string Type { get; set; }
        public List<string> AddrLines { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}