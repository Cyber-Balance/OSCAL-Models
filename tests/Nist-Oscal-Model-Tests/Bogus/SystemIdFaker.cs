using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class SystemIdFaker : AutoFaker<Models.Core.SystemId>
    {
        public const string uri = "https://ietf.org/rfc/rfc4122";
        public SystemIdFaker()
        {
            RuleFor(r => r.IdentifierType, f => uri);
            RuleFor(r => r.Id, f => f.Random.UuidV4().ToString());
        }
    }
}
