using AutoBogus;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    class ImportSspFaker : AutoFaker<Models.Core.ImportSsp>
    {
        public ImportSspFaker()
        {

            RuleFor(r => r.Href, f => f.Internet.UrlWithPath());
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));

        }
    }
}
