using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class LocationFaker : AutoFaker<Models.Core.Location>
    {
        public LocationFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.EmailAddresses, f => (new[] { f.Person.Email }).ToList().OrNull(f, 0.5f));
            //RuleFor(l => l.Links, f => f.CreateListOrEmpty<Models.Core.Link>());
            RuleFor(l => l.Links, f => new LinkFaker().GenerateBetween(1, 2).OrEmptyList(f, 0.5f));
            RuleFor(l => l.Props, f => new PropFaker().Generate(1, $"{BogusExtensions.DefaultRuleSet},{BogusExtensions.DataCenterRuleSet}").OrEmptyList(f));
            RuleFor(l => l.TelephoneNumbers, f => new TelephoneNumberFaker().GenerateBetween(1, 2).OrEmptyList(f, 0.5f));
            RuleFor(l => l.Address, f => new AddressFaker().Generate());
            RuleFor(l => l.Title, f => f.Lorem.Title().OrDefault(f, 0.5f));
            RuleFor(l => l.Urls, f => f.Make(f.Random.Number(1, 2), () => f.Internet.UrlWithPath()).OrNull(f, 0.5f));
            RuleFor(l => l.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}