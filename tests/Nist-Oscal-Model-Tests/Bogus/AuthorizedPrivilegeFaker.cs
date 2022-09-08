using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class AuthorizedPrivilegeFaker : AutoFaker<Models.Core.AuthorizedPrivilege>
    {
        public AuthorizedPrivilegeFaker()
        {
            RuleFor(r => r.Title, f => f.Lorem.Title());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.FunctionsPerformed, f => f.Make(3, () => f.Random.Word()));
        }
    }
}
