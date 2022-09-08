using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class LeveragedAuthorization
    {
        public LeveragedAuthorization()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public Guid PartyUuid { get; set; }
        public DateTime DateAuthorized { get; set; }
        public string Remarks { get; set; }

    }
}
