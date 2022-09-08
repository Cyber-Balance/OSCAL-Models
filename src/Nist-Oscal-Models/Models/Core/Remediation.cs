using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Remediation
    {
        public Remediation()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Origins = new List<Origin>();
            RequiredAssets = new List<RequiredAsset>();
            Tasks = new List<Task>();
        }
        public Guid Uuid { get; set; }
        public string Lifecycle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<Origin> Origins { get; set; }
        public List<RequiredAsset> RequiredAssets { get; set; }
        public List<Task> Tasks { get; set; }
        public string Remarks { get; set; }

    }
}
