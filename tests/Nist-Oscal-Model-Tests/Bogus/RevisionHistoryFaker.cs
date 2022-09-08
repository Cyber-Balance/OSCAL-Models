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
    public class RevisionHistoryFaker : AutoFaker<Models.Core.RevisionHistory>
    {
        public RevisionHistoryFaker()
        {
            RuleFor(h => h.Title, f => f.Lorem.Title());
            RuleFor(h => h.Published, f => f.Date.Past().OrNull(f, 0.5f));
            RuleFor(h => h.LastModified, f => f.Date.Past().OrNull(f, 0.5f));
            RuleFor(h => h.Version, f => f.System.Semver());
            RuleFor(h => h.OscalVersion, f => BogusExtensions.OscalVersion.OrDefault(f, 0.5f));
            //RuleFor(m => m.Props, f => f.CreateListOrEmpty<Models.Core.Prop>());
            //RuleFor(m => m.Links, f => f.CreateListOrEmpty<Models.Core.Link>());
            RuleFor(m => m.Props, f => new PropFaker().GenerateBetween(1, 3));
            RuleFor(m => m.Links, f => new LinkFaker().GenerateBetween(1, 3));
            RuleFor(m => m.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}