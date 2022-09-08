using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class AvailabilityImpactFaker : AutoFaker<Models.SystemSecurityPlan.AvailabilityImpact>
    {
        public AvailabilityImpactFaker()
        {
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Base, f => f.Lorem.Paragraph());
            RuleFor(r => r.Selected, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.AdjustmentJustification, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
