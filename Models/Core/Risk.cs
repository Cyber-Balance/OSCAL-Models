using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Risk
    {
        public Risk()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Origins = new List<Origin>();
            ThreatIds = new List<ThreatId>();
            Characterizations = new List<Characterizations>();
            MitigatingFactors = new List<MitigatingFactor>();
            Remediations = new List<Remediation>();
            RelatedObservations = new List<RelatedObservation>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Statement { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public string Status { get; set; }
        public List<Origin> Origins { get; set; }
        public List<ThreatId> ThreatIds { get; set; }
        public List<Characterizations> Characterizations { get; set; }
        public List<MitigatingFactor> MitigatingFactors { get; set; }
        public DateTime Deadline { get; set; }
        public List<Remediation> Remediations { get; set; }
        public RiskLog RiskLog { get; set; }
        public List<RelatedObservation> RelatedObservations { get; set; }


    }
}
