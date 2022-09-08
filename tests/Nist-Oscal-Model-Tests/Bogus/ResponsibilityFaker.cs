using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class ResponsibilityFaker : AutoFaker<Models.SystemSecurityPlan.Responsibility>
    {
        public ResponsibilityFaker()
        {
            RuleFor(c => c.Uuid, f => f.Random.UuidV4());
            RuleFor(c => c.ProvidedUuid, f => f.Random.UuidV4());
            RuleFor(c => c.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ResponsibleRoles, f => new ResponsibleRoleFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));

        }
    }
}
