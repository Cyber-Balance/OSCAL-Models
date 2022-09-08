using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.PlanOfActionAndMilestones
{
    public class Origin
    {
        public Origin()
        {
            Actors = new List<Actor>();
            
        }
        public List<Actor> Actors { get; set; }
        
    }
}
