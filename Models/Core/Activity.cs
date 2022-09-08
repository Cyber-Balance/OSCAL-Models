using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Activity
    {
        public Activity()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Steps = new List<Step>();
            ResponsibleRoles = new List<ResponsibleRole>();
        }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<Step> Steps { get; set; }
        public RelatedControl RelatedControls { get; set; }
        public List<ResponsibleRole> ResponsibleRoles { get; set; }
        public string Remarks { get; set; }

    }
}
