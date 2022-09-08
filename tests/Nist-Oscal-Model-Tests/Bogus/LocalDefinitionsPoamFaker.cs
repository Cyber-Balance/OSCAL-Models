using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class LocalDefinitionsPoamFaker : AutoFaker<Models.PlanOfActionAndMilestones.LocalDefinitions>
    {
        public LocalDefinitionsPoamFaker()
        {
            RuleFor(r => r.Components, f => new ComponentFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.InventoryItems, f => new InventoryItemCoreFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
