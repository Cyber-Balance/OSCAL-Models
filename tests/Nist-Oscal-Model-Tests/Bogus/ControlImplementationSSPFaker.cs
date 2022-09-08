using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ControlImplementationSSPFaker : AutoFaker<Models.SystemSecurityPlan.ControlImplementation>
    {
        public ControlImplementationSSPFaker()
        {
            RuleFor(i => i.Description, f => f.Lorem.Paragraph());
            RuleFor(i => i.SetParameters, f => new SetParameterFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(i => i.ImplementedRequirements, f => new ImplementedRequirementSSPFaker().GenerateBetween(1, 3));
        }
    }
}
