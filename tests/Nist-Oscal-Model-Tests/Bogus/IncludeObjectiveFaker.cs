using AutoBogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class IncludeObjectiveFaker : AutoFaker<Models.Core.IncludeObjective>
    {
        public IncludeObjectiveFaker()
        {
            RuleFor(c => c.ObjectiveId, f => f.Lorem.Slug());
        }
    }
}
