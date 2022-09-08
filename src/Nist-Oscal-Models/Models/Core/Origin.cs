using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Origin
    {
        public Origin()
        {
            Actors = new List<Actor>();
            RelatedTasks = new List<RelatedTask>();
        }
        public List<Actor> Actors { get; set; }
        public List<RelatedTask> RelatedTasks { get; set; }
    }
}
