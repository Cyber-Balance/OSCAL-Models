using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ControlImplementationFaker : AutoFaker<Models.Core.ControlImplementation>
    {
        public ControlImplementationFaker()
        {
            RuleFor(i => i.Uuid, f => f.Random.UuidV4());
            RuleFor(i => i.Source, f => f.Internet.Url());
            RuleFor(i => i.Description, f => f.Lorem.Paragraph());
            RuleFor(i => i.Props, f => f.CreateListOrEmpty<Models.Core.Prop>());
            RuleFor(i => i.Links, f => f.CreateListOrEmpty<Models.Core.Link>());
            RuleFor(i => i.SetParameters, f => new SetParameterFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(i => i.ImplementedRequirements, f => new ImplementedRequirementFaker().GenerateBetween(1, 3));
        }
    }
}
