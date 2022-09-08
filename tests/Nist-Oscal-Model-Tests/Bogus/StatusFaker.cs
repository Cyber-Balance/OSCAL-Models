using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class StatusFaker : AutoFaker<Models.Core.Status>
    {
        private const string underdevelopment = "under-development";
        public const string operational = "operational";
        public const string disposition = "disposition";
        public const string other = "other";
        
        private static readonly string[] status = new[] { underdevelopment, operational, disposition, other};

        public StatusFaker()
        {
            RuleFor(r => r.State, f => f.PickRandom(status));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
