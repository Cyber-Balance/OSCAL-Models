using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class ByComponentFaker : AutoFaker<Models.SystemSecurityPlan.ByComponent>
    {
        public ByComponentFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.ComponentUuid, f => f.Random.UuidV4());
            RuleFor(c => c.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.SetParameters, f => new SetParameterFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ImplementationStatus, f => new ImplementationStatusFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(r => r.Export, f => new ExportFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(r => r.Inherited, f => new InheritedFaker().GenerateBetween(1, 3));
            RuleFor(r => r.Satisfied, f => new SatisfiedFaker().GenerateBetween(1, 3));
            RuleFor(r => r.ResponsibleRoles, f => new ResponsibleRoleFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
