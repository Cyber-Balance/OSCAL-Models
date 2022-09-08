using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Control
    {
        public Control()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            IncludeControls = new List<IncludeControl>();
            ExcludeControls = new List<ExcludeControl>();
        }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public object IncludeAll { get; set; }
        public List<IncludeControl> IncludeControls { get; set; }
        public List<ExcludeControl> ExcludeControls { get; set; }
        public string Remarks { get; set; }
    
    }
}
