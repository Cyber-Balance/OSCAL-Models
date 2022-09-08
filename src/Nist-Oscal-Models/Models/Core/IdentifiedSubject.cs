using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class IdentifiedSubject
    {
        public IdentifiedSubject()
        {
            Subjects = new List<AssessmentSubject>();
        }
        public Guid SubjectPlaceholderUuid { get; set; }
        public List<AssessmentSubject> Subjects { get; set; }
    }
}
