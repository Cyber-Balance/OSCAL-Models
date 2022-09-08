using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class BackMatterFaker : AutoFaker<Models.ComponentDefinition.BackMatter>
    {
        public BackMatterFaker()
        {
            RuleFor(b => b.Resources, f => new ResourcesFaker().GenerateBetween(1, 3));
        }
    }
}
