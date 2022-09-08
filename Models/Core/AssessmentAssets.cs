using System;
using System.Collections.Generic;
using System.Text;
using Nist.Oscal.Models.ComponentDefinition;
using Nist.Oscal.Models.Core;

namespace Nist.Oscal.Models.Core
{
    public class AssessmentAssets
    {
        public AssessmentAssets()
        {
            AssessmentPlatforms = new List<AssessmentPlatform>();
        }
        public List<Component> Components { get; set; }
        public List<AssessmentPlatform> AssessmentPlatforms { get; set; }

    }
}
