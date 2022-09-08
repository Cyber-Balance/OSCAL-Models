using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class AssessmentPlatform
    {
        public AssessmentPlatform()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            UsesComponents = new List<UsesComponent>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<UsesComponent> UsesComponents { get; set; }
        public string Remarks { get; set; }
    }
}
