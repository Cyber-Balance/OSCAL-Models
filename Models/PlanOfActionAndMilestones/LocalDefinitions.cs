using System;
using System.Collections.Generic;
using System.Text;
using Nist.Oscal.Models.Core;

namespace Nist.Oscal.Models.PlanOfActionAndMilestones
{
    public class LocalDefinitions
    {
        public LocalDefinitions()
        {
            Components = new List<Component>();
            InventoryItems = new List<InventoryItem>();
        }
        public List<Component> Components { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
        public string Remarks { get; set; }
    
    }
}
