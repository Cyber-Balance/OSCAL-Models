using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class RelatedTask
    {
        public RelatedTask()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            ResponsibleParties = new List<ResponsibleParty>();
            Subjects = new List<AssessmentSubject>();
        }
        public Guid TaskUuid { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<ResponsibleParty> ResponsibleParties { get; set; }
        public List<AssessmentSubject> Subjects { get; set; }
        public IdentifiedSubject IdentifiedSubject { get; set; }
        public string Remarks { get; set; }

    }
}
