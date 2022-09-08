using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.AssessmentResults
{
    public class Attestation
    {
        public Attestation()
        {
            ResponsibleParties = new List<ResponsibleParty>();
            Parts = new List<AssessmentPart>();
        }
        public List<ResponsibleParty> ResponsibleParties { get; set; }
        public List<AssessmentPart> Parts { get; set; }

    }
}
