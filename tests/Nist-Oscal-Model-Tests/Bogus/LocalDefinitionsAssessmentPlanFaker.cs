using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class LocalDefinitionsAssessmentPlanFaker : AutoFaker<Models.AssessmentPlan.LocalDefinitions>
    {
        public LocalDefinitionsAssessmentPlanFaker()
        {
            RuleFor(r => r.Components, f => new ComponentFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.InventoryItems, f => new InventoryItemCoreFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Users, f => new UserFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ObjectivesAndMethods, f => new ObjectivesAndMethodsFaker().GenerateBetween(1, 3));
            RuleFor(r => r.Activities, f => new ActivityFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
