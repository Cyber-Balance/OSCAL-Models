using Nist.Oscal.Models.ComponentDefinition;
using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.AssessmentResults
{
    public class AssessmentResults
    {
        public AssessmentResults()
        {
            Results = new List<Result>();
        }
        public Guid Uuid { get; set; }
        public Metadata Metadata { get; set; }
        public ImportAp ImportAp { get; set; }
        public LocalDefinitions LocalDefinitions { get; set; }
        public List<Result> Results { get; set; }
        public BackMatter BackMatter { get; set; }

    }

    public class AssessmentResultsDocument
    {
        public AssessmentResults AssessmentResults { get; set; }
    }
}
