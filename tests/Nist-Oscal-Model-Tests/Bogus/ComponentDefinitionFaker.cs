using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class ComponentDefinitionFaker : AutoFaker<Models.ComponentDefinition.ComponentDefinition>
    {
        public ComponentDefinitionFaker()
        {
            RuleFor(c => c.Uuid, f => f.Random.UuidV4());
            RuleFor(c => c.Metadata, f => new MetaDataFaker().Generate());
            RuleFor(c => c.Components, f => new ComponentWithOutStatusFaker().GenerateBetween(1, 3));
            RuleFor(c => c.Capabilities, f => new CapabilityFaker().GenerateBetween(1, 3));
            RuleFor(c => c.BackMatter, f => new BackMatterFaker().Generate());
        }
    }
}
