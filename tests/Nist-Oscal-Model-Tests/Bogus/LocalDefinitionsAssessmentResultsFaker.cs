using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class LocalDefinitionsAssessmentResultsFaker : AutoFaker<Models.AssessmentResults.LocalDefinitions>
    {
        public LocalDefinitionsAssessmentResultsFaker()
        {
            RuleFor(r => r.ObjectivesAndMethods, f => new ObjectivesAndMethodsFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Activities, f => new ActivityFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        
        }
    }
}
