using System;
using Nist.Oscal.Models.Core;
using System.Collections.Generic;

namespace Nist.Oscal.Models.ComponentDefinition
{
    public class Capability
    {
        public Capability()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            IncorporatesComponents = new List<IncorporateComponent>();
            ControlImplementations = new List<ControlImplementation>();
        }

        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<IncorporateComponent> IncorporatesComponents { get; set; }
        public List<ControlImplementation> ControlImplementations { get; set; }
        public string Remarks { get; set; }
    }
}