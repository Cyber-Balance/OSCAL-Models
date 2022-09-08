using Nist.Oscal.Models.ComponentDefinition;
using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class SystemImplementation
    {
        public SystemImplementation()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            LeveragedAuthorizations = new List<LeveragedAuthorization>();
            Users = new List<User>();
            Components = new List<Component>();
            InventoryItems = new List<InventoryItem>();
        }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<LeveragedAuthorization> LeveragedAuthorizations { get; set; }
        public List<User> Users { get; set; }
        public List<Component> Components { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
        public string Remarks { get; set; }

    }
}
