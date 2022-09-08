using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class ImplementedRequirement
    {
        public ImplementedRequirement()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            SetParameters = new List<SetParameter>();
            ResponsibleRoles = new List<ResponsibleRole>();
            Statements = new List<SspStatement>();
        }

        public Guid Uuid { get; set; }
        public string ControlId { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<SetParameter> SetParameters { get; set; }
        public List<ResponsibleRole> ResponsibleRoles { get; set; }
        public List<SspStatement> Statements { get; set; }
        public List<ByComponent> ByComponents { get; set; }  
        public string Remarks { get; set; }
    }
}