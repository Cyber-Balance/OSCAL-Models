using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Facet
    {
        public Facet()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }
        public string Name { get; set; }
        public string System { get; set; }
        public string Value { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public string Remarks { get; set; }

    }
}
