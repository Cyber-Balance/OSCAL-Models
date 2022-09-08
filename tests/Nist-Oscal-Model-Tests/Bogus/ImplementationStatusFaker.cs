using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ImplementationStatusFaker : AutoFaker<Models.SystemSecurityPlan.ImplementationStatus>
    {
        private const string implemented = "implemented";
        private const string partial = "partial";
        private const string planned = "planned";
        private const string alternative = "alternative";
        private const string notapplicable = "not-applicable";

        private static readonly string[] states = new[] {implemented, partial, planned, alternative, notapplicable };


        public ImplementationStatusFaker()
        {
            RuleFor(c => c.State, f => f.PickRandom(Enumerable.Concat(states, new[] { f.Lorem.Word().ToLower() })));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
