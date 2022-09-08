using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class UsesComponentFaker : AutoFaker<Models.Core.UsesComponent>
    {
        public UsesComponentFaker()
        {
            RuleFor(l => l.ComponentUuid, f => f.Random.UuidV4());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ResponsibleParties, f => new ResponsiblePartyFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
