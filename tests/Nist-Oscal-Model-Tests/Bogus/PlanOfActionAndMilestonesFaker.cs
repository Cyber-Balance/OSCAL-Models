using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class PlanOfActionAndMilestonesFaker : AutoFaker<Models.PlanOfActionAndMilestones.PlanOfActionAndMilestones>
    {
        public PlanOfActionAndMilestonesFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(r => r.Metadata, f => new MetaDataFaker().Generate());
            RuleFor(r => r.ImportSsp, f => new ImportSspFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(r => r.LocalDefinitions, f => new LocalDefinitionsPoamFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(r => r.Observations, f => new ObservationFaker().GenerateBetween(1, 3));
            RuleFor(r => r.Risks, f => new RiskFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.PoamItems, f => new PoamItemFaker().GenerateBetween(1, 3));
            RuleFor(r => r.BackMatter, f => new BackMatterFaker().Generate().OrDefault(f, 0.5f));
        }
    }
}
