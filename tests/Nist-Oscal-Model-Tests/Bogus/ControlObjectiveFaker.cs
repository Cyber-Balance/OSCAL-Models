using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class ControlObjectiveFaker : AutoFaker<Models.Core.ControlObjective>
    {
        public ControlObjectiveFaker()
        {
            RuleFor(c => c.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(c => c.IncludeAll, f => new object().OrDefault(f, 0.5f));
            RuleFor(r => r.IncludeObjectives, f => new IncludeObjectiveFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
