using AutoBogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    internal class PlanOfActionAndMilestonesDocumentFaker : AutoFaker<Models.PlanOfActionAndMilestones.PlanOfActionAndMilestonesDocument>
    {
        public PlanOfActionAndMilestonesDocumentFaker()
        {
            RuleFor(d => d.PlanOfActionAndMilestones, f => new PlanOfActionAndMilestonesFaker().Generate());
        }
    }
}