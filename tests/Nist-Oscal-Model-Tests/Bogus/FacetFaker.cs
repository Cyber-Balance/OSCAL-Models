using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class FacetFaker : AutoFaker<Models.Core.Facet>
    {
        private const string url1 = "http://fedramp.gov";
        private const string url2 = "http://csrc.nist.gov/ns/oscal";
        private const string url3 = "http://csrc.nist.gov/ns/oscal/unknown";
        private const string url4 = "http://cve.mitre.org";
        private const string url5 = "http://www.first.org/cvss/v2.0";
        private const string url6 = "http://www.first.org/cvss/v3.0";
        private const string url7 = "http://www.first.org/cvss/v3.1";
        private static readonly string[] Names = new[] { url1, url2, url3, url4, url5, url6, url7 };

        public FacetFaker()
        {
            RuleFor(c => c.Name, f => f.Lorem.Slug());
            RuleFor(c => c.System, f => f.PickRandom(Enumerable.Concat(Names, new[] { f.Lorem.Word().ToLower() })));
            RuleFor(c => c.Value, f => f.Lorem.Text());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
