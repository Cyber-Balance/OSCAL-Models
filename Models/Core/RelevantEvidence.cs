using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class RelevantEvidence
    {
        public RelevantEvidence()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }
        public string Href { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public string Remarks { get; set; }
    }
}
