using Nist.Oscal.Models.ComponentDefinition;
using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class ControlImplementation
    {
        public ControlImplementation()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            SetParameters = new List<SetParameter>();
            ImplementedRequirements = new List<ImplementedRequirement>();
        }

        public Guid Uuid { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<SetParameter> SetParameters { get; set; }
        public List<ImplementedRequirement> ImplementedRequirements { get; set; }
    }
}
