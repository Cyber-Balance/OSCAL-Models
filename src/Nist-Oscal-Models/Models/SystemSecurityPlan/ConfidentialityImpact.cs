using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class ConfidentialityImpact { 
    
        public ConfidentialityImpact()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public string Base { get; set; }
        public string Selected { get; set; }
        public string AdjustmentJustification { get; set; }

    }
}
