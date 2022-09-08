using System;
using System.Collections.Generic;
using System.Text;
using Nist.Oscal.Models.Core;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class SystemInformation
    {
        public SystemInformation()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            InformationTypes = new List<InformationType>();
        }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<InformationType> InformationTypes { get; set; }

    }
}
