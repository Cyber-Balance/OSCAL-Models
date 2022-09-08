using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class RiskFaker : AutoFaker<Models.Core.Risk>
    {
        private const string open = "open";
        private const string investigating = "investigating";
        private const string remediating = "remediating";
        private const string deviationrequested = "deviation-requested";
        private const string deviationapproved = "deviation-approved";
        private const string closed = "closed";
        private static readonly string[] all_status = new[] { open, investigating, remediating, deviationrequested, deviationapproved, closed };
        public RiskFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.Title, f => f.Lorem.Title());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph());
            RuleFor(l => l.Statement, f => f.Lorem.Sentences());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(c => c.Status, f => f.PickRandom(Enumerable.Concat(all_status, new[] { f.Lorem.Word().ToLower() })));
            RuleFor(r => r.Origins, f => new OriginFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));

            RuleFor(r => r.ThreatIds, f => new ThreatIdFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Characterizations, f => new CharacterizationsFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.MitigatingFactors, f => new MitigatingFactorFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Remediations, f => new RemediationFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.RiskLog, f => new RiskLogFaker().Generate().OrDefault(f, 0.5f));

            RuleFor(r => r.Deadline, f => f.Date.Future());
            RuleFor(r => r.RelatedObservations, f => new RelatedObservationFaker().GenerateBetween(1, 3));
        }
    }
}
