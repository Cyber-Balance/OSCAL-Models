using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ResourcesFaker : AutoFaker<Models.ComponentDefinition.Resource>
    {
        public ResourcesFaker()
        {
            RuleFor(r => r.Uuid, f => f.Random.UuidV4());
            RuleFor(r => r.Title, f => f.Lorem.Title().OrDefault(f, 0.5f));
            RuleFor(r => r.Description, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 2).OrEmptyList(f, 0.5f));
            RuleFor(r => r.DocumentIds, f => new ExternalIdentifierFaker().GenerateBetween(1, 2).OrEmptyList(f, 0.5f));
            //RuleFor(r => r.DocumentIds, f => f.CreateListOrEmpty<Models.Core.ExternalIdentifier>(1, f.Random.Bool(0.75f) ? 1 : 2, 0.75f));
            RuleFor(r => r.Citation, f => new Models.ComponentDefinition.Citation
            {
                Text = f.Lorem.Sentence(),
                Props = new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f),
                Links = new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f)
            }.OrDefault(f, 0.5f));
            RuleFor(r => r.Rlinks, f => new RlinkFaker().GenerateBetween(1, 2).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Base64, f => new Base64Faker().Generate());
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
