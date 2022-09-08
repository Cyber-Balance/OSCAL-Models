using AutoBogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class ThreatIdFaker : AutoFaker<Models.Core.ThreatId>
    {
        private const string system = "https://fedramp.gov";
        public ThreatIdFaker()
        {
            RuleFor(l => l.System, system);
            RuleFor(l => l.Href, (f, l) => f.Internet.UrlWithPath());
            RuleFor(l => l.Id, f => f.Lorem.Text());
        }
    }
}
