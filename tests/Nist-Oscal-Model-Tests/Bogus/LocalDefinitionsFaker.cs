using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class LocalDefinitionsFaker : AutoFaker<Models.AssessmentResults.LocalDefinitions>
    {
        public LocalDefinitionsFaker()
        {
            RuleFor(r => r.ObjectivesAndMethods, f => new ObjectivesAndMethodsFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Activities, f => new ActivityFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }

    }
}
