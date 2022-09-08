using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Step
    {
        public Step()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
    }
}
