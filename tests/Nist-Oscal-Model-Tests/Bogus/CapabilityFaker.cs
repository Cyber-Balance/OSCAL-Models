using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class CapabilityFaker : AutoFaker<Models.ComponentDefinition.Capability>
    {
        public CapabilityFaker()
        {
            RuleFor(c => c.Uuid, f => f.Random.UuidV4());
            RuleFor(p => p.Name, f => f.Lorem.Slug());
            RuleFor(p => p.Description, f => f.Lorem.Paragraph());
            RuleFor(p => p.Props, f => f.CreateListOrEmpty<Models.Core.Prop>(1, 3, 0.5f));
            RuleFor(p => p.Links, f => f.CreateListOrEmpty<Models.Core.Link>(1, 3, 0.5f));
            RuleFor(p => p.IncorporatesComponents, f =>
            {
                return f.Make(f.Random.Int(1, 2), _ =>
                {
                    return new Models.ComponentDefinition.IncorporateComponent
                    {
                        ComponentUuid = f.Random.UuidV4(),
                        Description = f.Lorem.Paragraph()
                    };
                }).OrEmptyList(f, 0.5f);
            });
            RuleFor(c => c.ControlImplementations, f => new ControlImplementationFaker().GenerateBetween(1, 20).OrEmptyList(f, 0.25f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
