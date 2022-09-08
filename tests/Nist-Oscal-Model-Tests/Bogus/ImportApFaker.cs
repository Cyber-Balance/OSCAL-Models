using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    class ImportApFaker : AutoFaker<Models.AssessmentResults.ImportAp>
    {
        public ImportApFaker()
        {
            RuleFor(r => r.Href, f => f.Internet.UrlWithPath());
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
