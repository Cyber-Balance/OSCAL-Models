using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class SecurityImpactLevel
    {
        public string SecurityObjectiveConfidentiality { get; set; }
        public string SecurityObjectiveIntegrity { get; set; }
        public string SecurityObjectiveAvailability { get; set; }
    }
}
