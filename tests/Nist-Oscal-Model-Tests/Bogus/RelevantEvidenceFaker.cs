using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class RelevantEvidenceFaker : AutoFaker<Models.Core.RelevantEvidence>
    {
        public RelevantEvidenceFaker()
        { 
            RuleFor(c => c.Description, f => f.Lorem.Paragraph());
            RuleFor(l => l.Href, (f, l) => f.Internet.UrlWithPath());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
