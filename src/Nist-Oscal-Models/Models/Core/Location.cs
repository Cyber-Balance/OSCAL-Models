using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class Location
    {
        public Location()
        {
            EmailAddresses = new List<string>();
            TelephoneNumbers = new List<TelephoneNumber>();
            Urls = new List<string>();
            Props = new List<Prop>();
            Links = new List<Link>();
        }

        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public Address Address { get; set; }
        public List<string> EmailAddresses { get; set; }
        public List<TelephoneNumber> TelephoneNumbers { get; set; }
        public List<string> Urls { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public string Remarks { get; set; }
    }
}