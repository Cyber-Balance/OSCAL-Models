using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Nist.Oscal.Models.ComponentDefinition;
using Nist.Oscal.Models.Core;

namespace Nist.Oscal.Models.AssessmentPlan
{
    public class AssessmentPlan
    {
        public AssessmentPlan()
        {
            AssessmentSubjects = new List<AssessmentSubject>();
            Tasks = new List<Core.Task>();
        }

        public Guid Uuid { get; set; }
        public Metadata Metadata { get; set; }
        public ImportSsp ImportSsp { get; set; }
        public LocalDefinitions LocalDefinitions { get; set; }
        public TermsAndCondition TermsAndConditions { get; set; }
        public ReviewedControl ReviewedControls { get; set; }
        public List<AssessmentSubject> AssessmentSubjects { get; set; }
        public AssessmentAssets AssessmentAssets { get; set; }
        public List<Core.Task> Tasks { get; set; }
        public BackMatter BackMatter { get; set; }

    }

    public class AssessmentPlanDocument
    {
        public AssessmentPlan AssessmentPlan { get; set; }
    }
}

