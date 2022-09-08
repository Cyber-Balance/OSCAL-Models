using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class InformationTypeFaker : AutoFaker<Models.SystemSecurityPlan.InformationType>
    {
        public InformationTypeFaker()
        {

            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(r => r.Title, f => f.Lorem.Title());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph());
            RuleFor(l => l.Categorizations, f => new CategorizationFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(c => c.ConfidentialityImpact, f => new ConfidentialityImpactFaker().Generate());
            RuleFor(c => c.IntegrityImpact, f => new IntegrityImpactFaker().Generate());
            RuleFor(c => c.AvailabilityImpact, f => new AvailabilityImpactFaker().Generate());
        }
    }
}
