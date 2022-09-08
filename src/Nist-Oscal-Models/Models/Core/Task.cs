using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Task
    {
        public Task()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            Dependencies = new List<Dependency>();
            Tasks = new List<Task>();
            AssociatedActivities = new List<AssociatedActivity>();
            Subjects = new List<AssessmentSubject>();
            ResponsibleRoles = new List<ResponsibleRole>();
        }
        public Guid Uuid { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public Timing Timing { get; set; }
        public List<Dependency> Dependencies { get; set; }
        public List<Task> Tasks { get; set; }
        public List<AssociatedActivity> AssociatedActivities { get; set; }
        public List<AssessmentSubject> Subjects { get; set; }
        public List<ResponsibleRole> ResponsibleRoles { get; set; }
        public string Remarks { get; set; }

    }
}
