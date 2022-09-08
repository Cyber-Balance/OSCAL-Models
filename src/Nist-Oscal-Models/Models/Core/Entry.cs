using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Entry
    {
        public Entry()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            LoggedBy = new List<LoggedBy>();
            RelatedResponses = new List<RelatedResponse>();
            LoggedBy = new List<LoggedBy>();
        }

        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<LoggedBy> LoggedBy { get; set; }
        public string StatusChange { get; set; }
        public List<RelatedResponse> RelatedResponses { get; set; }
        
    }
}
