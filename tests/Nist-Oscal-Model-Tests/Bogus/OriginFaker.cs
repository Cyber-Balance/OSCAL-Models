using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class OriginFaker : AutoFaker<Models.Core.Origin>
    {
        public OriginFaker()
        {
            RuleFor(r => r.Actors, f => new ActorFaker().GenerateBetween(1, 3));
            RuleFor(r => r.RelatedTasks, f => new RelatedTaskFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
