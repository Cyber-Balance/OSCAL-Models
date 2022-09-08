using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class MitigatingFactor
    {
        public MitigatingFactor()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Subjects = new List<SubjectReference>();
        }
        public Guid Uuid { get; set; }
        public Guid ImplementationUuid { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<SubjectReference> Subjects { get; set; }

    }
}
