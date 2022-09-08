using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class RevisionHistory
    {
        public RevisionHistory()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }

        public string Title { get; set; }
        public DateTime? Published { get; set; }
        public DateTime? LastModified { get; set; }
        public string Version { get; set; }
        public string OscalVersion { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public string Remarks { get; set; }
    }
}