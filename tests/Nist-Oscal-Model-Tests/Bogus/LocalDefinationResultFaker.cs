using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class LocalDefinationResultFaker : AutoFaker<Models.AssessmentResults.LocalDefinitionResult>
    {
        public LocalDefinationResultFaker()
        {
            RuleFor(r => r.Components, f => new ComponentFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.InventoryItems, f => new InventoryItemCoreFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.AssessmentAssets, f => new AssessmentAssetsFaker().Generate());
            RuleFor(r => r.Tasks, f => new TaskFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
