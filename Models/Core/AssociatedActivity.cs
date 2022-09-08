using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class AssociatedActivity
    {
        public AssociatedActivity()
        {
            ResponsibleRoles = new List<ResponsibleRole>();
            Props = new List<Prop>();
            Links = new List<Link>();
            Subjects = new List<AssessmentSubject>();
        }
        public Guid ActivityUuid { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<ResponsibleRole> ResponsibleRoles { get; set; }
        public List<AssessmentSubject> Subjects { get; set; }
        public string Remarks { get; set; }

    }
}
