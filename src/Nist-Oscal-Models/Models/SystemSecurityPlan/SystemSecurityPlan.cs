using System;
using System.Collections.Generic;
using System.Text;
using Nist.Oscal.Models.ComponentDefinition;
using Nist.Oscal.Models.Core;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class SystemSecurityPlan
    {
        public Guid Uuid { get; set; }
        public Metadata Metadata { get; set; }
        public ImportProfile ImportProfile { get; set; }
        public SystemCharacteristics SystemCharacteristics { get; set; }
        public SystemImplementation SystemImplementation { get; set; }
        public ControlImplementation ControlImplementation { get; set; }
        public BackMatter BackMatter { get; set; }

    }

    public class SystemSecurityPlanDocument
    {
        public SystemSecurityPlan SystemSecurityPlan { get; set; }
    }
}
