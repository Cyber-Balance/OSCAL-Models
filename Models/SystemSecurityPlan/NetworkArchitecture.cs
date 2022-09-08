using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class NetworkArchitecture
    {
        public NetworkArchitecture()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Diagrams = new List<Diagram>();
        }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<Diagram> Diagrams { get; set; }
        public string Remarks { get; set; }
    }
}
