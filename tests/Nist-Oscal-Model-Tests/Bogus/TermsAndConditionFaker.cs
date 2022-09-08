using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class TermsAndConditionFaker : AutoFaker<Models.AssessmentPlan.TermsAndCondition>
    {
        public TermsAndConditionFaker()
        {
            RuleFor(r => r.Parts, f => new AssessmentPartFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
