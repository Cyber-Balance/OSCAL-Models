using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Characterizations
    {
        public Characterizations()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Facets = new List<Facet>();
        }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public Origin Origin { get; set; }
        public List<Facet> Facets { get; set; }

    }
}
