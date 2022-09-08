using AutoBogus;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class ComponentDocumentDefinitionFaker : AutoFaker<Models.ComponentDefinition.ComponentDefinitionDocument>
    {
        public ComponentDocumentDefinitionFaker()
        {
            RuleFor(d => d.ComponentDefinition, f => new ComponentDefinitionFaker().Generate());
        }
    }
}
