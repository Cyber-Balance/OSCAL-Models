using System.Collections.Generic;
using System;
using Nist.Oscal.Models.Core;

namespace Nist.Oscal.Models.Core
{
    public class Statement
    {
        public Statement()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            ResponsibleRoles = new List<ResponsibleRole>();
        }

        public string StatementId { get; set; }
        public Guid Uuid { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<ResponsibleRole> ResponsibleRoles { get; set; }
        public string Remarks { get; set; }
    }
}