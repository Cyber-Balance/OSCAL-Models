using System;
using System.Collections.Generic;
using System.Text;
using Component = Nist.Oscal.Models.Core.Component;
using Nist.Oscal.Models.Core;


namespace Nist.Oscal.Models.AssessmentResults
{
    public class LocalDefinitionResult
    {
        public LocalDefinitionResult()
        {
            Components = new List<Component>();
            InventoryItems = new List<InventoryItem>();
            Users = new List<User>();
            Tasks = new List<Task>();
        }
        public List<Component> Components { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
        public List<User> Users { get; set; }
        public AssessmentAssets AssessmentAssets { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
