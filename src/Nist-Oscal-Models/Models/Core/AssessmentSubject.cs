using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class AssessmentSubject
    { 
        public AssessmentSubject()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            IncludeSubjects = new List<SelectSubjectById>();
            ExcludeSubjects = new List<SelectSubjectById>();
        }
        public string Type { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public object IncludeAll { get; set; }
        public List<SelectSubjectById> IncludeSubjects { get; set; }
        public List<SelectSubjectById> ExcludeSubjects { get; set; }
        public string Remarks { get; set; }
    }
}