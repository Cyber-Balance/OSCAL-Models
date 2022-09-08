using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class ReviewedControlFaker : AutoFaker<Models.Core.ReviewedControl>
    {
        public ReviewedControlFaker()
        {
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Description, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
            RuleFor(r => r.ControlSelections, f => new ControlFaker().GenerateBetween(1, 3));
            RuleFor(r => r.ControlObjectiveSelections, f => new ControlObjectiveFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
