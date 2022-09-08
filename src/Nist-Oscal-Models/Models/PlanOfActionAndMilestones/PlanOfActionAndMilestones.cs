using Nist.Oscal.Models.ComponentDefinition;
using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.PlanOfActionAndMilestones
{
    public class PlanOfActionAndMilestones
    {
        public PlanOfActionAndMilestones()
        {
            Observations = new List<Observation>();
            Risks = new List<Risk>();
            PoamItems = new List<PoamItem>();

        }
        public Guid Uuid { get; set; }
        public Metadata Metadata { get; set; }
        public ImportSsp ImportSsp { get; set; }
        public SystemId SystemId { get; set; }
        public LocalDefinitions LocalDefinitions { get; set; }
        public List<Observation> Observations { get; set; }
        public List<Risk> Risks { get; set; }
        public List<PoamItem> PoamItems { get; set; }
        public BackMatter BackMatter { get; set; }

    }

    public class PlanOfActionAndMilestonesDocument
    {
        public PlanOfActionAndMilestones PlanOfActionAndMilestones { get; set; }
    }
}
