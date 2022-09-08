using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class InventoryItemFaker : AutoFaker<Models.Core.InventoryItem>
    {
        public InventoryItemFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(l => l.ResponsibleParties, f => new ResponsiblePartyFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(c => c.ImplementedComponents, f => new ImplementedComponentFaker().GenerateBetween(1,3).OrEmptyList(f, 0.5f));
        }
    }
}
