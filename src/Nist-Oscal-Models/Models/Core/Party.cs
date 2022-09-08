using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class Party
    {
        public Party()
        {
            ExternalIds = new List<ExternalId>();
            Props = new List<Prop>();
            Links = new List<Link>();
            EmailAddresses = new List<string>();
            TelephoneNumbers = new List<TelephoneNumber>();
            Addresses = new List<Address>();
            MemberOfOrganizations = new List<string>();
        }

        public Guid Uuid { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        //public List<ExternalIdentifier> ExternalIds { get; set; }
        public List<ExternalId> ExternalIds { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<string> EmailAddresses { get; set; }
        public List<TelephoneNumber> TelephoneNumbers { get; set; }
        public List<Address> Addresses { get; set; }
        public List<string> LocationUuids { get; set; }
        public List<string> MemberOfOrganizations { get; set; }
        public string Remarks { get; set; }
    }
}
