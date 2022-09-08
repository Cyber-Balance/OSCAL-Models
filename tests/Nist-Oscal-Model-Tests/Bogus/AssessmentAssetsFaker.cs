using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssessmentAssetsFaker : AutoFaker<Models.Core.AssessmentAssets>
    {
        public AssessmentAssetsFaker()
        {
            RuleFor(l => l.Components, f => new ComponentFaker().GenerateBetween(1, 3));
            RuleFor(l => l.AssessmentPlatforms, f => new AssessmentPlatformFaker().GenerateBetween(1, 3));
        }
    }
}
