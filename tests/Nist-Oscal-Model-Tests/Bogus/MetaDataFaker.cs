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
    public class MetaDataFaker : AutoFaker<Models.Core.Metadata>
    {
        private readonly List<Guid> backmatterReferences = new List<Guid>();

        public MetaDataFaker()
        {
            RuleFor(m => m.Title, f => f.Lorem.Title());
            RuleFor(m => m.OscalVersion, BogusExtensions.OscalVersion);
            //RuleFor(m => m.DocumentIds, f => f.CreateListOrEmpty<Models.Core.ExternalIdentifier>(1, f.Random.Bool(0.75f) ? 1 : 2, 0.75f));
            RuleFor(m => m.DocumentIds, f => new ExternalIdentifierFaker().GenerateBetween(1, 3));
            //RuleFor(m => m.DocumentIds, f => f.CreateListOrEmpty<Models.Core.ExternalIdentifierDcoumentId>());
            //RuleFor(m => m.Props, f => f.CreateListOrEmpty<Models.Core.Prop>());
            RuleFor(m => m.Props, f => new PropFaker().GenerateBetween(1, 3));
            RuleFor(m => m.Links, f => new LinkFaker().GenerateBetween(1, 3));
            RuleFor(m => m.Roles, f => new RoleFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(m => m.Locations, f => new LocationFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(m => m.Parties, f => new PartyFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(m => m.ResponsibleParties, f => new ResponsiblePartyFaker().GenerateBetween(1, 3));
            RuleFor(m => m.Remarks, f => f.Lorem.Paragraph().OrDefault(f));

            //RuleFor(m => m.Links, f =>
            //{
            //    var links = f.CreateListOrEmpty<Models.Core.Link>(1, 2);
            //    var url1 = "http://fedramp.gov";
            //    var backmatter = backmatterReferences.Any() ? f.PickRandom(backmatterReferences).OrNull(f) : null;
            //    if (backmatter != null)
            //    {
            //        var link = AutoFaker.Generate<Models.Core.Link>();
            //        link.Href = $"#{backmatter}";
            //        link.MediaType = null;
            //    }
            //    else
            //    {
            //        var link = AutoFaker.Generate<Models.Core.Link>();
            //        link.MediaType = null;
            //        link.Href = url1;
            //    }
            //    return links;
            //});

            string documentVersion = default;
            RuleFor(m => m.LastModified, f => f.Date.Recent());
            RuleFor(m => m.Published, (f, u) => GetRelativelyRecentDate(f, u.LastModified).OrNull(f));
            RuleFor(m => m.Revisions, (f, u) =>
            {
                var revisions = new RevisionHistoryFaker().GenerateBetween(1, 5);//.OrEmptyList(f, 0.5f);
                var oldest = new[] { u.Published, u.LastModified }.Where(d => d != null).Min();
                var versions = f.Make(revisions.Count() + 1, () => f.System.Semver()).OrderByDescending(v => new Version(v)).ToArray();
                var i = 1;

                documentVersion = versions[0];

                foreach (var revision in revisions)
                {
                    revision.Version = versions[i++];//.OrDefault(f);
                    revision.LastModified = GetRelativelyRecentDate(f, oldest).OrNull(f);
                    revision.Published = GetRelativelyRecentDate(f, revision.LastModified ?? oldest).OrNull(f);

                    oldest = new[] { revision.Published, revision.LastModified, oldest }.Where(d => d != null).Min();
                }

                return revisions;
            });

            RuleFor(m => m.Version, f => documentVersion ?? f.System.Semver());
        }

        private static DateTime GetRelativelyRecentDate(Faker f, DateTime? referenceDate = default) 
            => f.Date.Recent(f.Random.Int(15, 90), referenceDate);

        public MetaDataFaker WithBackMatterReferences(IEnumerable<Guid> uuids)
        {
            backmatterReferences.AddRange(uuids);
            return this;
        }
    }
}
