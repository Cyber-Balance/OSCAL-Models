using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class ControlObjective
    {
        public ControlObjective()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            IncludeObjectives = new List<IncludeObjective>();
        }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public object IncludeAll { get; set; }
        public List<IncludeObjective> IncludeObjectives { get; set; }
    }
}
