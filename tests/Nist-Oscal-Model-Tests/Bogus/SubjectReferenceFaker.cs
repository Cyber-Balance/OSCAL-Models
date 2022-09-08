using System;
using Bogus;
using AutoBogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    internal class SubjectReferenceFaker : AutoFaker<Models.Core.SubjectReference>
    {
        private const string includeall = "all";
        private const string component = "component";
        public const string inventoryitem = "inventory-item";
        public const string location = "location";
        public const string party = "party";
        public const string user = "user";
        private static readonly string[] all_types = new[] { component, inventoryitem, location, party, user };

        public SubjectReferenceFaker()
        {
            RuleFor(l => l.SubjectUuid, f => f.Random.UuidV4());
            RuleFor(c => c.Type, f => f.PickRandom(Enumerable.Concat(all_types, new[] { f.Lorem.Word().ToLower() })));
            RuleFor(c => c.Title, f => f.Lorem.Title());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
