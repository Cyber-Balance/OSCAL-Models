using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class LeveragedAuthorizationFaker : AutoFaker<Models.SystemSecurityPlan.LeveragedAuthorization>
    {
        //public DateTime dateAuthorized = new DateTime(2020, 01, 01);
        public LeveragedAuthorizationFaker()
        {

            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(r => r.Title, f => f.Lorem.Title());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(l => l.PartyUuid, f => f.Random.UuidV4());
            RuleFor(h => h.DateAuthorized, f => f.Date.Past());
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
