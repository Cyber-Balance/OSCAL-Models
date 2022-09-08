using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class SystemSecurityPlanFaker : AutoFaker<Models.SystemSecurityPlan.SystemSecurityPlan>
    {
        public SystemSecurityPlanFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.Metadata, f => new MetaDataFaker().Generate());
            RuleFor(l => l.ImportProfile, f => new ImportProfileFaker().Generate());
            RuleFor(l => l.SystemCharacteristics, f => new SystemCharacteristicsFaker().Generate());
            RuleFor(l => l.SystemImplementation, f => new SystemImplementationFaker().Generate());
            RuleFor(l => l.ControlImplementation, f => new ControlImplementationSSPFaker().Generate());
            RuleFor(l => l.BackMatter, f => new BackMatterFaker().Generate().OrDefault(f, 0.5f));
        }
    }
}
