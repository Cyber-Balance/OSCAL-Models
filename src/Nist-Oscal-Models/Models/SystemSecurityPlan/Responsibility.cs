using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class Responsibility
    {
        public Responsibility()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            ResponsibleRoles = new List<ResponsibleRole>();
        }
    
    public Guid Uuid { get; set; }
    public Guid ProvidedUuid { get; set; }
    public string Description { get; set; }
    public List<Prop> Props { get; set; }
    public List<Link> Links { get; set; }
    public List<ResponsibleRole> ResponsibleRoles { get; set; }
    public string Remarks { get; set; }
    
    }
}
