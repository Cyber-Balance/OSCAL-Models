using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class ExportFaker : AutoFaker<Models.SystemSecurityPlan.Export>
    {
        public ExportFaker()
        {
            RuleFor(c => c.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Provided, f => new ProvidedFaker().GenerateBetween(1, 3));
            RuleFor(r => r.Responsibilities, f => new ResponsibilityFaker().GenerateBetween(1, 3));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
