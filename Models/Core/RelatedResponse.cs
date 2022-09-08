using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class RelatedResponse
    {
        public RelatedResponse()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            RelatedTasks = new List<RelatedTask>();
        }
        public Guid Uuid { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<RelatedTask> RelatedTasks { get; set; }
        public string Remarks { get; set; }
    }
}
