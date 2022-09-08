using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class InformationType
    {
        public InformationType()
        {
            Categorizations = new List<Categorization>();
            Props = new List<Prop>();
            Links = new List<Link>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Categorization> Categorizations { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public ConfidentialityImpact ConfidentialityImpact { get; set; }
        public IntegrityImpact IntegrityImpact { get; set; }
        public AvailabilityImpact AvailabilityImpact { get; set; }

    }
}
