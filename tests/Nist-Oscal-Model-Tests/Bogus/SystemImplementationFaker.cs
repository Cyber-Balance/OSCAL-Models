using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class SystemImplementationFaker : AutoFaker<Models.SystemSecurityPlan.SystemImplementation>
    {
        public SystemImplementationFaker()
        {


            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(l => l.LeveragedAuthorizations, f => new LeveragedAuthorizationFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(l => l.Users, f => new UserFaker().GenerateBetween(1, 3));
            RuleFor(l => l.Components, f => new ComponentFaker().GenerateBetween(1, 3));
            RuleFor(l => l.InventoryItems, f => new InventoryItemFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
