using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssessmentResultsFaker : AutoFaker<Models.AssessmentResults.AssessmentResults>
    {
        public AssessmentResultsFaker()
        {
            RuleFor(c => c.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.Metadata, f => new MetaDataFaker());
            RuleFor(l => l.ImportAp, f => new ImportApFaker().Generate());
            RuleFor(l => l.LocalDefinitions, f => new LocalDefinitionsFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(l => l.Results, f => new ResultFaker().GenerateBetween(1, 3));
            RuleFor(l => l.BackMatter, f => new BackMatterFaker().Generate().OrDefault(f, 0.5f));
        }
    }
}
