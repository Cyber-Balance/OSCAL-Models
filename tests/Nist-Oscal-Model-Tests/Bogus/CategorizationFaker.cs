using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class CategorizationFaker : AutoFaker<Models.SystemSecurityPlan.Categorization>
    {
        public const string System = "https://doi.org/10.6028/NIST.SP.800-60v2r1";
        public CategorizationFaker()
        {
            RuleFor(r => r.System, f => f.Internet.Url());
            RuleFor(r => r.InformationTypeIds, f => f.Make(3, () => f.Random.Word()).OrEmptyList(f, 0.5f));
        }
    }
}
