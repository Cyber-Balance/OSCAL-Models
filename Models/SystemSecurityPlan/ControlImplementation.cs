using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class ControlImplementation
    {
        public ControlImplementation()
        {
            SetParameters = new List<SetParameter>();
            ImplementedRequirements = new List<ImplementedRequirement>();
        }

        public string Description { get; set; }
        public List<SetParameter> SetParameters { get; set; }
        public List<ImplementedRequirement> ImplementedRequirements { get; set; }
    }
}