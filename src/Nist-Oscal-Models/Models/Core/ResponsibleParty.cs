using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class ResponsibleParty
    {
        public ResponsibleParty()
        {
            PartyUuids = new List<Guid>();
            Props = new List<Prop>();
            Links = new List<Link>();
        }

        public string RoleId { get; set; }
        public List<Guid> PartyUuids { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public string Remarks { get; set; }
    }
}