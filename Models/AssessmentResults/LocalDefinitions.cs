using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.AssessmentResults
{
    public class LocalDefinitions
    {
        public LocalDefinitions()
        {
            ObjectivesAndMethods = new List<ObjectivesAndMethods>();
            Activities = new List<Activity>();
        }
        public List<ObjectivesAndMethods> ObjectivesAndMethods { get; set; }
        public List<Activity> Activities { get; set; }
        public string Remarks { get; set; }
    }
}
