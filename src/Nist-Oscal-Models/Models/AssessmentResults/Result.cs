using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.AssessmentResults
{
    public class Result
    {
        public Result()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Observations = new List<Observation>();
            Risks = new List<Risk>();
            Attestations = new List<Attestation>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public LocalDefinitionResult LocalDefinitions { get; set; }
        public ReviewedControl ReviewedControls { get; set; }
        public List<Attestation> Attestations { get; set; }
        public AssessmentLog AssessmentLog { get; set; }
        public List<Observation> Observations { get; set; }
        public List<Risk> Risks { get; set; }
        public string Remarks { get; set; }
    }
}
