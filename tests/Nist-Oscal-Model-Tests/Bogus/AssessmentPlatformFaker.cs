using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssessmentPlatformFaker : AutoFaker<Models.Core.AssessmentPlatform>
    {
        public AssessmentPlatformFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(c => c.Title, f => f.Lorem.Title());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.UsesComponents, f => new UsesComponentFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
