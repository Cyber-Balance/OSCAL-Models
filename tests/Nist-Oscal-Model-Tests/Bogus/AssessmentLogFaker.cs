using AutoBogus;
using Bogus;
using Bogus.Extensions;
using Nist.Oscal.Tests.Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssessmentLogFaker : AutoFaker<Models.AssessmentResults.AssessmentLog>
    {
        public AssessmentLogFaker()
        {
            RuleFor(r => r.Entries, f => new EntryFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
