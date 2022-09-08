using AutoBogus;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssessmentPlanFaker : AutoFaker<Models.AssessmentPlan.AssessmentPlan>
    {
        public AssessmentPlanFaker()
        {
            RuleFor(c => c.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.Metadata, f => new MetaDataFaker().Generate());
            RuleFor(l => l.ImportSsp, f => new ImportSspFaker().Generate());

            RuleFor(l => l.LocalDefinitions, f => new LocalDefinitionsAssessmentPlanFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(l => l.TermsAndConditions, f => new TermsAndConditionFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(l => l.ReviewedControls, f => new ReviewedControlFaker().Generate());

            RuleFor(l => l.AssessmentAssets, f => new AssessmentAssetsFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(l => l.AssessmentSubjects, f => new AssessmentSubjectFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            
            RuleFor(l => l.Tasks, f => new TaskFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(l => l.BackMatter, f => new BackMatterFaker().Generate().OrDefault(f, 0.5f));
        }
    }
}
