using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Component = Nist.Oscal.Models.Core.Component;

namespace Nist.Oscal.Models.AssessmentPlan
{
    public class LocalDefinitions
    {
        public LocalDefinitions()
        {
            Components = new List<Component>();
            InventoryItems = new List<InventoryItem>();
            Users = new List<User>();
            ObjectivesAndMethods = new List<ObjectivesAndMethods>();
            Activities = new List<Activity>();
        }
        public List<Component> Components { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
        public List<User> Users { get; set; }
        public List<ObjectivesAndMethods> ObjectivesAndMethods { get; set; }
        public List<Activity> Activities { get; set; }
        public string Remarks { get; set; }
    
    }
}
