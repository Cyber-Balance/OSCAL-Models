using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    class ExcludeControlFaker : AutoFaker<Models.Core.ExcludeControl>
    {
        public ExcludeControlFaker()
        {
            RuleFor(l => l.ControlId, f => f.Lorem.Slug());
            RuleFor(p => p.StatementIds, f => f.Make(f.Random.WeightedRandom(new[] { 1, 2 }, new[] { 0.75f, 0.25f }), () => f.Lorem.Word()).OrDefault(f, 0.5f));
        }
                
    }
}
