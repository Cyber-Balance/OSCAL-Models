using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssessmentSubjectFaker : AutoFaker<Models.Core.AssessmentSubject>
    {
        private const string includeall = "all";
        private const string component = "component";
        public const string inventoryitem = "inventory-item";
        public const string location = "location";
        public const string party = "party";
        public const string user = "user";
        private static readonly string[] all_types = new[] { component, inventoryitem, location, party, user };

        public AssessmentSubjectFaker()
        {
            RuleFor(c => c.Type, f => f.PickRandom(Enumerable.Concat(all_types, new[] { f.Lorem.Word().ToLower() })));
            RuleFor(c => c.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(c => c.IncludeAll, f => new object().OrDefault(f, 0.5f));
            RuleFor(r => r.IncludeSubjects, f => new SelectSubjectByIdFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ExcludeSubjects, f => new SelectSubjectByIdFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
