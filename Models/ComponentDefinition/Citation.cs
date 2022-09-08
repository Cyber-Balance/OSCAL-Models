using Nist.Oscal.Models.Core;
using System.Collections.Generic;

namespace Nist.Oscal.Models.ComponentDefinition
{
    public class Citation
    {
        public Citation()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }

        public string Text { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
    }
}