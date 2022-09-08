using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class UserFaker : AutoFaker<Models.Core.User>
    {
        public UserFaker()
        {

            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(r => r.Title, f => f.Lorem.Title().OrDefault(f, 0.5f));
            RuleFor(r => r.ShortName, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.Description, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.RoleIds, f => f.Make(3, () => f.Lorem.Slug()).OrEmptyList(f, 0.5f));
            RuleFor(l => l.AuthorizedPrivileges, f => new AuthorizedPrivilegeFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
