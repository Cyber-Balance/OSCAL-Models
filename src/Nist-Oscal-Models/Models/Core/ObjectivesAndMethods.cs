using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class ObjectivesAndMethods
    {
        public ObjectivesAndMethods()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
        }
        public string ControlId { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Part> Parts { get; set; }
        public virtual List<Link> Links { get; set; }
        public string Remarks { get; set; }

    }
}
