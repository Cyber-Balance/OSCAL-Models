using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class SspStatement
    {
        public SspStatement()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            ResponsibleRoles = new List<ResponsibleRole>();
        }

        public string StatementId { get; set; }
        public Guid Uuid { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<ResponsibleRole> ResponsibleRoles { get; set; }
        public List<ByComponent> ByComponents { get; set; } 
        public string Remarks { get; set; }
    }
}