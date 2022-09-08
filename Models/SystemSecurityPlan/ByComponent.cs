using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class ByComponent
    {
        public ByComponent()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            SetParameters = new List<SetParameter>();
            Inherited = new List<Inherited>();
            Satisfied = new List<Satisfied>();
            ResponsibleRoles = new List<ResponsibleRole>(); 
        }
        public Guid ComponentUuid { get; set; }
        public Guid Uuid { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<SetParameter> SetParameters { get; set; }
        public ImplementationStatus ImplementationStatus { get; set; }
        public Export Export { get; set; }
        public List<Inherited> Inherited { get; set; } 
        public List<Satisfied> Satisfied { get; set; }
        public List<ResponsibleRole> ResponsibleRoles { get; set; }
        public string Remarks { get; set; }

    }
}
