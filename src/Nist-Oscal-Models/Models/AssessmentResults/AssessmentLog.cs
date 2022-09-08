using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.AssessmentResults
{
    public class AssessmentLog
    {
        public AssessmentLog()
        {
            Entries = new List<Entry>();
        }
        public List<Entry> Entries { get; set; }
    }
}
