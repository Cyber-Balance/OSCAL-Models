using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class PropFaker : AutoFaker<Models.Core.Prop>
    {
        private const string yes = "yes";
        private const string no = "no";
        private const string type = "type";
        private const string mailstop = "mail-stop";
        private const string office = "office";
        private const string jobtitle = "job-title";
        private const string datacenter = "data-center";
        private const string primary = "primary";
        private const string alternate = "alternate";
        private const string version = "version";
        private const string patchlevel = "patch-level";
        private const string model = "model";
        private const string releasedate = "release-date";
        private const string validationtype = "validation-type";
        private const string validationreference = "validation-reference";
        private const string assettype = "asset-type";
        private const string assetid = "asset-id";
        private const string assettag = "asset=tag";
        private const string @public = "public";
        private const string @virtual = "virtual";
        private const string vlanid = "vlan-id";
        private const string networkid = "network-id";
        private const string label = "label";
        private const string sortid = "sort-id";
        private const string baselineconfigurationname = "baseline-configuration-name";
        private const string allowsauthenticatedscan = "allows-authenticated-scan";
        private const string function = "function";
        private const string implementationpoint = "implementation-point";
        private const string @internal = "internal";
        private const string external = "external";
        private const string physicallocation = "physical-location";
        private const string inheriteduuid = "inherited-uuid";
        private const string softwareidentifier = "software-identifier";

        private const string operatingsystem = "operating-system";
        private const string database = "database";
        private const string webserver = "web-server";
        private const string dnsserver = "dns-server";
        private const string emailserver = "email-server";
        private const string directoryserver = "directory-server";
        private const string pbx = "pbx";
        private const string firewall = "firewall";
        private const string router = "router";
        private const string @switch = "switch";
        private const string storagearray = "storage-array";
        private const string applicance = "applicance";

        public PropFaker()
        {
            RuleFor(p => p.Uuid, f => f.Random.UuidV4());
            RuleFor(p => p.Name, f => f.Lorem.Slug());
            RuleFor(p => p.Ns, f => $"http://{f.Internet.DomainName()}/ns/oscal".ToLowerInvariant());
            RuleFor(p => p.Class, f => f.Lorem.Word().OrDefault(f, 0.75f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
            RuleFor(p => p.Value, f => f.Random.Number(0, 12) switch
            {
                0 => f.Lorem.Word().Trim(),
                1 => f.Lorem.Slug().Trim(),
                2 => f.Random.Int().ToString("#,#", CultureInfo.InvariantCulture).Trim(),
                3 => f.Random.Decimal().ToString("#,#0.0###", CultureInfo.InvariantCulture).Trim(),
                4 => f.Random.UuidV4().ToString().Trim(),
                5 => f.Date.Timespan().ToString("c").Trim(),
                6 => f.Date.Recent().ToString("u").Trim(),
                7 => $"{f.Random.Int().ToString().Trim()} {f.Random.Word().Trim()}",
                8 => $"{f.Random.Decimal().ToString().Trim()}{f.Random.Word().Trim()}",
                9 => f.Vehicle.Vin().Trim(),
                10 => f.Random.Int().ToString().Trim(),
                11 => f.Random.Decimal().ToString("#0.##%", CultureInfo.InvariantCulture).Trim(),
                _ => f.Random.AlphaNumeric(f.Random.Number(5, 15)).Trim()
            });

            RuleSet(BogusExtensions.PersonRuleSet, rules =>
            {
                RuleFor(p => p.Name, f => f.PickRandom(mailstop, office, jobtitle));
                RuleFor(p => p.Ns, f => Models.Core.Prop.DefaultNamespace.OrDefault(f, 0.5f));
                RuleFor(p => p.Value, (f, u) => GetValue(f, u.Name));
            });

            RuleSet(BogusExtensions.OrganizationRuleSet, rules =>
            {
                RuleFor(p => p.Name, f => f.PickRandom(mailstop, office));
                RuleFor(p => p.Ns, f => Models.Core.Prop.DefaultNamespace.OrDefault(f, 0.5f));
                RuleFor(p => p.Value, (f, u) => GetValue(f, u.Name));
            });

            RuleSet(BogusExtensions.DataCenterRuleSet, rules =>
            {
                RuleFor(p => p.Name, type);
                RuleFor(p => p.Ns, f => Models.Core.Prop.DefaultNamespace.OrDefault(f, 0.5f));
                RuleFor(p => p.Value, (f, u) => GetValue(f, u.Name));
                RuleFor(p => p.Class, f => f.PickRandomParam(primary, alternate).OrDefault(f, 0.5f));
            });

            RuleSet(BogusExtensions.AssetRuleSet, rules =>
            {
                RuleFor(p => p.Name, f => f.PickRandom(assettype, assetid, assettag, model, @public, @virtual, vlanid, networkid, label, sortid, baselineconfigurationname, allowsauthenticatedscan, function, patchlevel));
                RuleFor(p => p.Ns, f => Models.Core.Prop.DefaultNamespace.OrDefault(f, 0.5f));
                RuleFor(p => p.Value, (f, u) => GetValue(f, u.Name));
            });

            RuleSet(BogusExtensions.SoftwareRuleSet, rules =>
            {
                RuleFor(p => p.Name, f => f.PickRandom(version, patchlevel, releasedate, label, softwareidentifier));
                RuleFor(p => p.Ns, f => Models.Core.Prop.DefaultNamespace.OrDefault(f, 0.5f));
                RuleFor(p => p.Value, (f, u) => GetValue(f, u.Name));
            });

            RuleSet(BogusExtensions.ValidationRuleSet, rules =>
            {
                RuleFor(p => p.Name, f => f.PickRandom(version, releasedate, label, validationreference, validationtype));
                RuleFor(p => p.Ns, f => Models.Core.Prop.DefaultNamespace.OrDefault(f, 0.5f));
                RuleFor(p => p.Value, (f, u) => GetValue(f, u.Name));
            });

            RuleSet(BogusExtensions.PolicyRuleSet, rules =>
            {
                RuleFor(p => p.Name, f => f.PickRandom(version, releasedate, label, model));
                RuleFor(p => p.Ns, f => Models.Core.Prop.DefaultNamespace.OrDefault(f, 0.5f));
                RuleFor(p => p.Value, (f, u) => GetValue(f, u.Name));
            });

            RuleSet(BogusExtensions.ComponentRuleSet, rules =>
            {
                RuleFor(p => p.Name, f => f.PickRandom(version, releasedate, label, model, implementationpoint));
                RuleFor(p => p.Ns, f => Models.Core.Prop.DefaultNamespace.OrDefault(f, 0.5f));
                RuleFor(p => p.Value, (f, u) => GetValue(f, u.Name));
            });

            static string GetValue(Faker faker, string name)
                => name switch
                {
                    mailstop => faker.Address.FullAddress(),
                    office => faker.Address.SecondaryAddress().Replace("Apt.", faker.Address.CardinalDirection()),
                    jobtitle => faker.Name.JobTitle(),
                    type => datacenter,
                    version => faker.System.Semver(),
                    patchlevel => faker.Random.AlphaNumeric(faker.Random.Int(5, 15)),
                    model => faker.Commerce.ProductName(),
                    releasedate => faker.Date.Past().ToString("yyyy-MM-dd"),
                    validationtype => faker.Hacker.IngVerb(),
                    validationreference => faker.Vehicle.Vin(),
                    assettype => faker.PickRandom(operatingsystem, database, webserver, dnsserver, emailserver, directoryserver, pbx, firewall, router, @switch, storagearray, applicance),
                    assetid => faker.PickRandom(faker.System.AndroidId(), faker.Random.Guid().ToString(), faker.Commerce.Ean13(), faker.Commerce.Ean8()),
                    assettag => faker.Random.AlphaNumeric(faker.Random.Int(5, 10)),
                    @public => faker.PickRandom(yes, no),
                    @virtual => faker.PickRandom(yes, no),
                    vlanid => $"VLAN {faker.Random.Int(1, 4094)}",
                    networkid => string.Join(".", faker.Internet.Ip().Split(".").Take(2)),
                    label => faker.Lorem.Slug(),
                    sortid => faker.Random.AlphaNumeric(faker.Random.Int(5, 12)),
                    baselineconfigurationname => faker.Lorem.Slug(),
                    allowsauthenticatedscan => faker.PickRandom(yes, no),
                    function => $"{faker.Hacker.Verb()} {faker.Hacker.Noun()}",
                    implementationpoint => faker.PickRandom(@internal, external),
                    softwareidentifier => faker.PickRandom(faker.Commerce.Ean8(), faker.Commerce.ProductName()),
                    inheriteduuid => faker.Random.UuidV4().ToString(),
                    _ => faker.Lorem.Word()
                };
        }
    }
}
