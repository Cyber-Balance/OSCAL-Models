using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class PoamOriginFaker : AutoFaker<Models.PlanOfActionAndMilestones.Origin>
    {
        public PoamOriginFaker()
        {
            RuleFor(r => r.Actors, f => new ActorFaker().GenerateBetween(1, 3));
        }
    }
}
