using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class ResponsibleRole
    {
        public ResponsibleRole()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            PartyUuids = new List<Guid>();
        }
        public string RoleId { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<Guid> PartyUuids { get; set; }
        public string Remarks { get; set; }
    }
}
