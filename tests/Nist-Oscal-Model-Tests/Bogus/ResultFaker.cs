using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class ResultFaker : AutoFaker<Models.AssessmentResults.Result>
    {
        public ResultFaker() 
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.Title, f => f.Lorem.Title());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph());
            RuleFor(h => h.Start, f => f.Date.Past());
            RuleFor(h => h.End, f => f.Date.Future());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.LocalDefinitions, f => new LocalDefinationResultFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(r => r.ReviewedControls, f => new ReviewedControlFaker().Generate());
            RuleFor(r => r.Attestations, f => new AttestationsFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            //RuleFor(r => r.AssessmentLog, f => new AssessmentLogFaker().Generate().OrDefault(f, 0.5f));
            //RuleFor(r => r.Observations, f => new ObservationFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            //RuleFor(r => r.Risks, f => new RiskFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
