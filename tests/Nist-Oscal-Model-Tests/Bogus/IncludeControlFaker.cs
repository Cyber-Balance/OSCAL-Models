using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class IncludeControlFaker : AutoFaker<Models.Core.IncludeControl>
    {
        private readonly List<string> StatementId = new List<string>();
        public IncludeControlFaker()
        {
            RuleFor(l => l.ControlId, f => f.Lorem.Slug());
            RuleFor(p => p.StatementIds, f => PickRandom(f, StatementId));
        }

        private IEnumerable<string> PickRandom(Faker f, IEnumerable<string> list)
        {
            if (list.Any() == false)
            {
                return default;
            }

            if (list.Count() == 1)
            {
                return new[] { list.First() }.OrDefault(f);
            }

            return f.PickRandom(list, f.Random.WeightedRandom(new[] { 1, 2 }, new[] { 0.8f, 0.2f })).OrDefault(f);
        }
    }
}
