using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Actor
    {
        public Actor()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }
        public string type { get; set; }
        public Guid ActorUuid { get; set; }
        public string RoleId { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }

    }
}
