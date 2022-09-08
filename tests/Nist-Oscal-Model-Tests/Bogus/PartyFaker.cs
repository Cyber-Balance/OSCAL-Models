using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using AutoBogus;
using Bogus.Extensions;
using System.Linq;
using Bogus;

namespace Nist.Oscal.Tests.Bogus
{
    public class PartyFaker : AutoFaker<Models.Core.Party>
    {
        private const string person = "person";
        private const string organization = "organization";

        private readonly List<string> locationIds = new List<string>();
        private readonly List<string> organizationIds = new List<string>();

        public PartyFaker()
        {

            RuleFor(p => p.Uuid, f => f.Random.UuidV4());
            RuleFor(p => p.Type, f => f.PickRandomParam(person, organization));
            //RuleFor(p => p.ExternalIds, f => f.CreateListOrEmpty<Models.Core.ExternalIdentifierExternalId>());
            RuleFor(p => p.ExternalIds, f => new ExternalIdentifierExternalIdFaker().GenerateBetween(1, 3));
            RuleFor(p => p.Name, (f, u) => CreateName(f, u.Type).OrDefault(f, 0.25f));
            RuleFor(p => p.ShortName, (f, u) => (u.Name ?? CreateName(f, u.Type))
                                                .MakeShortName()
                                                .OrDefault(f, string.IsNullOrEmpty(u.Name) ? 0.0f : u.Type == organization ? 0.25f : 0.75f));

            RuleFor(p => p.Props, (f, u) => new PropFaker().Generate(2, GetRuleSet(u.Type)).OrEmptyList(f, 0.5f));
            //RuleFor(p => p.Links, f => f.CreateListOrEmpty<Models.Core.Link>());
            RuleFor(p => p.Links, f => new LinkFaker().GenerateBetween(1, 2).OrEmptyList(f, 0.5f));
            RuleFor(p => p.EmailAddresses, f => (new[] { f.Person.Email }).ToList().OrNull(f));
            RuleFor(p => p.TelephoneNumbers, f => new TelephoneNumberFaker().GenerateBetween(1, 2).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Addresses, (f, u) => new AddressFaker().Generate(1, GetRuleSet(u.Type)).OrEmptyList(f, 0.5f));
            RuleFor(p => p.LocationUuids, f => PickRandom(f, locationIds));
            RuleFor(p => p.MemberOfOrganizations, f => PickRandom(f, organizationIds));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
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

        public PartyFaker WithLocationIds(IEnumerable<string> uuids)
        {
            locationIds.AddRange(uuids);
            return this;
        }

        public PartyFaker WithOrganizationIds(IEnumerable<string> uuids)
        {
            organizationIds.AddRange(uuids);
            return this;
        }

        private static string GetRuleSet(string type)
        {
            var ruleset = type switch
            {
                person => BogusExtensions.PersonRuleSet,
                organization => BogusExtensions.OrganizationRuleSet,
                _ => BogusExtensions.DefaultRuleSet
            };

            return $"{BogusExtensions.DefaultRuleSet},{ruleset}";
        }

        private string CreateName(Faker f, string type) => type switch
        {
            person => f.Person.FullName,
            organization => f.Company.CompanyName(),
            _ => f.Lorem.Sentence(2).TrimEnd('.').Trim()
        };
    }
}