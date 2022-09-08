using Nist.Oscal.Models.Core;
using Nist.Oscal.Models.SystemSecurityPlan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class User
    {
        public User()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            RoleIds = new List<string>();
            AuthorizedPrivileges = new List<AuthorizedPrivilege>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<string> RoleIds { get; set; }
        public List<AuthorizedPrivilege> AuthorizedPrivileges { get; set; }
        public string Remarks { get; set; }

    }
}
