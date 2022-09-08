using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class ReviewedControl
    {
        public ReviewedControl()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            ControlSelections = new List<Control>();
            ControlObjectiveSelections = new List<ControlObjective>();
        }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<Control> ControlSelections { get; set; }
        public List<ControlObjective> ControlObjectiveSelections { get; set; }
        public string Remarks { get; set; }

    }
}
