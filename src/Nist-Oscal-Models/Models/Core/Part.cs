using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Part
    {
        public Part()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Parts = new List<Part>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Ns { get; set; }
        public string Class { get; set; }
        public string Title { get; set; }
        public List<Prop> Props { get; set; }
        public string Prose { get; set; }
        public List<Link> Links { get; set; }
        public List<Part> Parts { get; set; }

    }
}
