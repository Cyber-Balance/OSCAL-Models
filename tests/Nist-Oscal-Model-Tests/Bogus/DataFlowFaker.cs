using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class DataFlowFaker : AutoFaker<Models.SystemSecurityPlan.DataFlow>
    {
        public DataFlowFaker()
        {
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Diagrams, f => new DiagramFaker().GenerateBetween(1, 3));
            RuleFor(r => r.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));

        }
    }
}
