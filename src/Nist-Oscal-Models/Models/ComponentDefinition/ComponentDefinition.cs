using System;
using System.Collections.Generic;
using System.Text;
using Nist.Oscal.Models.Core;

namespace Nist.Oscal.Models.ComponentDefinition
{
    public class ComponentDefinition
    {
        public ComponentDefinition()
        {
            Components = new List<DefinedComponent>();
            Capabilities = new List<Capability>();
        }

        public Guid Uuid { get; set; }
        public Metadata Metadata { get; set; }
        public List<DefinedComponent> Components { get; set; }
        public List<Capability> Capabilities { get; set; }
        public BackMatter BackMatter { get; set; }
    }

    public class ComponentDefinitionDocument
    {
        public ComponentDefinition ComponentDefinition { get; set; }
    }
}
