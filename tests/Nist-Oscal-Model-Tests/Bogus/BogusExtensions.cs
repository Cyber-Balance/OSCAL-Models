using AutoBogus;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public static class BogusExtensions
    {
        public static List<T> CreateListOrEmpty<T>(this Faker f, int min = 1, int max = 3, float emptyWeight = 0.5f) 
            => AutoFaker.Generate<T>(f.Random.Int(min, max)).OrEmptyList(f, emptyWeight);

        public static List<T> OrEmptyList<T>(this IEnumerable<T> list, Faker f, float emptyWeight = 0.5f)
            => list.OrDefault(f, emptyWeight, Enumerable.Empty<T>()).ToList();

        public static string MakeShortName(this string name, string wordSeparator = " ")
            => string.IsNullOrEmpty(name)
            ? default 
            : string.Concat(name.Split(wordSeparator).Select(s => char.ToUpperInvariant(s[0])));

        public static string Title(this Lorem lorem) 
            => lorem.Sentence().TrimEnd('.').Trim();

        private static IEnumerable<string> PickRandomStr(this Faker f, IEnumerable<string> list)
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

        public const string OscalVersion = "1.1.0";
        

        public const string DefaultRuleSet = "default";
        public const string PersonRuleSet = "person";
        public const string OrganizationRuleSet = "organization";
        public const string DataCenterRuleSet = "datacenter";
        public const string AssetRuleSet = "asset";
        public const string SoftwareRuleSet = "software";
        public const string ValidationRuleSet = "validation";
        public const string PolicyRuleSet = "policy";
        public const string ComponentRuleSet = "component";
        public const string ResponsibleRoleRuleSet = "responsiblerole";
        public const string ResponsiblePartyRuleSet = "responsibleparty";
        public const string ServiceRuleSet = "service";
        public const string PartRuleSet = "part";
    }
}
