using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssessmentResultsDocumentFaker : AutoFaker<Models.AssessmentResults.AssessmentResultsDocument>
    {
        public AssessmentResultsDocumentFaker()
        {
            RuleFor(d => d.AssessmentResults, f => new AssessmentResultsFaker().Generate());
        }
    }
}
