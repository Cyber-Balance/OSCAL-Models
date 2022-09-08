using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class AttestationsFaker : AutoFaker<Models.AssessmentResults.Attestation>
    {
        public AttestationsFaker()
        { 
            RuleFor(r => r.ResponsibleParties, f => new ResponsiblePartyFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Parts, f => new AssessmentPartFaker().GenerateBetween(1, 3));
        }
    }
}
