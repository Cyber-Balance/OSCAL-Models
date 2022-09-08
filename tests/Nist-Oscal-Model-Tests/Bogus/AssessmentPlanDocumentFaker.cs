using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssessmentPlanDocumentFaker : AutoFaker<Models.AssessmentPlan.AssessmentPlanDocument>
    {
        public AssessmentPlanDocumentFaker()
        {
            RuleFor(d => d.AssessmentPlan, f => new AssessmentPlanFaker().Generate());
        }
    }
}