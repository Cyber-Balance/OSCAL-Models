using AutoBogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssociatedRiskFaker : AutoFaker<Models.PlanOfActionAndMilestones.AssociatedRisk>
    {
        public AssociatedRiskFaker()
        {
            RuleFor(l => l.RiskUuid, f => f.Random.UuidV4());
        }
    }
}
