using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class Role
    {
        public Role()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public string Remarks { get; set; }
    }
}
