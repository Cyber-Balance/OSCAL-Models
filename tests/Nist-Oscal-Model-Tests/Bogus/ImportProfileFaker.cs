using AutoBogus;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ImportProfileFaker : AutoFaker<Models.SystemSecurityPlan.ImportProfile>
    {
        public ImportProfileFaker()
        {
            
            RuleFor(r => r.Href, f => f.Internet.UrlWithPath());
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));

        }
    }
}
