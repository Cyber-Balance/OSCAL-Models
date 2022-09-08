using AutoBogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class RelatedObservationFaker : AutoFaker<Models.Core.RelatedObservation>
    {
        public RelatedObservationFaker()
        {
            RuleFor(r => r.ObservationUuid, f => f.Random.UuidV4());
        }
    }
}
