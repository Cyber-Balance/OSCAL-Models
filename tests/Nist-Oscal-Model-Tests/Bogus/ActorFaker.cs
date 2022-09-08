using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class ActorFaker : AutoFaker<Models.Core.Actor>
    {
        private const string tool = "tool";
        private const string assessmentplatform = "assessment-platform";
        private const string party = "party";
        private static readonly string[] types = new[] { tool, assessmentplatform, party };
        public ActorFaker()
        {
            //RuleFor(c => c.type, f => f.PickRandom(Enumerable.Concat(types, new[] { f.Lorem.Word().ToLower() })));
            RuleFor(c => c.type, f => f.PickRandom(types));
            RuleFor(l => l.ActorUuid, f => f.Random.UuidV4());
            RuleFor(l => l.RoleId, f => f.Lorem.Slug());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));

        }
    }
}
