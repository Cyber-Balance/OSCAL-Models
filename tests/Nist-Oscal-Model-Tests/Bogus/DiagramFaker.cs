using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class DiagramFaker : AutoFaker<Models.SystemSecurityPlan.Diagram>
    {
        public DiagramFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.Caption, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));

        }
    }
}
