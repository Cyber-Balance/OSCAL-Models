using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Observation
    {
        public Observation()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Methods = new List<string>();
            Types = new List<string>();
            Origins = new List<Origin>();
            Subjects = new List<SubjectReference>();
            RelevantEvidence = new List<RelevantEvidence>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<string> Methods { get; set; }
        public List<string> Types { get; set; }
        public List<Origin> Origins { get; set; }
        public List<SubjectReference> Subjects { get; set; }
        public List<RelevantEvidence> RelevantEvidence { get; set; }
        public DateTime Collected { get; set; }
        public DateTime Expires { get; set; }
        public string Remarks { get; set; }



    }
}
