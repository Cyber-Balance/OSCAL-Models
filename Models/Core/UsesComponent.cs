using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class UsesComponent
    {
        public UsesComponent()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            ResponsibleParties = new List<ResponsibleParty>();
        }
        public Guid ComponentUuid { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<ResponsibleParty> ResponsibleParties { get; set; }
        public string Remarks { get; set; }
    }
}
