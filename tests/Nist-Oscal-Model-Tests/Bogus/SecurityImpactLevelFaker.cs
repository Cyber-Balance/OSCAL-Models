using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class SecurityImpactLevelFaker : AutoFaker<Models.SystemSecurityPlan.SecurityImpactLevel>
    {
        public SecurityImpactLevelFaker()
        {
            RuleFor(r => r.SecurityObjectiveConfidentiality, f => f.Lorem.Paragraph());
            RuleFor(r => r.SecurityObjectiveIntegrity, f => f.Lorem.Paragraph());
            RuleFor(r => r.SecurityObjectiveAvailability, f => f.Lorem.Paragraph());
        }
    }
}
