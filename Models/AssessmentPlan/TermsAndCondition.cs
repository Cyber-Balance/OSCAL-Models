using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.AssessmentPlan
{
    public class TermsAndCondition
    {
        public TermsAndCondition()
        {
            Parts = new List<AssessmentPart>();
        }
        public List<AssessmentPart> Parts { get; set; }
    }
}
