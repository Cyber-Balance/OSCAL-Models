using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.PlanOfActionAndMilestones
{
    public class PoamItem
    {
        public PoamItem()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Origins = new List<Origin>();
            RelatedObservations = new List<RelatedObservation>();
            RelatedRisks = new List<AssociatedRisk>();
        }
   
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; } 
        public List<Link> Links { get; set; }
        public List<Origin> Origins { get; set; }
        public List<RelatedObservation> RelatedObservations { get; set; }
        public List<AssociatedRisk> RelatedRisks { get; set; }
        public string Remarks { get; set; }
        
    }
}
