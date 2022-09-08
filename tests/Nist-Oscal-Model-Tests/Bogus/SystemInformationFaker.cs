using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class SystemInformationFaker : AutoFaker<Models.SystemSecurityPlan.SystemInformation>
    {
        public SystemInformationFaker()
        {


            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(l => l.InformationTypes, f => new InformationTypeFaker().GenerateBetween(1, 3));
        }
    }
}
