using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class Export
    {
        public Export()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Provided = new List<Provided>();
        }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<Provided> Provided { get; set; }
        public List<Responsibility> Responsibilities { get; set; }
        public string Remarks { get; set; }

    }
}
