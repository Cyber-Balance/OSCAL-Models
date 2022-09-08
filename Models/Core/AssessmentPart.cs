using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class AssessmentPart
    {
        public AssessmentPart()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Parts = new List<AssessmentPart>();
        }
        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public string Ns { get; set; }
        public string Class { get; set; }
        public string Title { get; set; }
        public List<Prop> Props { get; set; }
        public string Prose { get; set; }
        public List<Link> Links { get; set; }
        public List<AssessmentPart> Parts { get; set; }
    }
}
