using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class Metadata
    {
        public Metadata()
        {
            Revisions = new List<RevisionHistory>();
            DocumentIds = new List<DocumentId>();
            Props = new List<Prop>();
            Links = new List<Link>();
            Roles = new List<Role>();
            Locations = new List<Location>();
            Parties = new List<Party>();
            ResponsibleParties = new List<ResponsibleParty>();
        }

        public string Title { get; set; }
        public DateTime? Published { get; set; }
        public DateTime LastModified { get; set; }
        public string Version { get; set; }
        public string OscalVersion { get; set; }
        public List<RevisionHistory> Revisions { get; set; }
        public List<DocumentId> DocumentIds { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<Role> Roles { get; set; }
        public List<Location> Locations { get; set; }
        public List<Party> Parties { get; set; }
        public List<ResponsibleParty> ResponsibleParties { get; set; }
        public string Remarks { get; set; }
    }
}
