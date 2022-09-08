using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ObservationFaker : AutoFaker<Models.Core.Observation>
    {
        public const string examine = "examine";
        public const string interview = "interview";
        public const string test = "test";
        public const string unknown = "unknown";
        public List<string> allmethods = new List<string>();
        
        //{ examine, interview, test, unknown };

        public const string sspstatementissue = "ssp-statement-issue";
        public const string controlobjective = "control-objective";
        public const string mitigation = "mitigation";
        public const string finding = "finding";
        public const string historic = "historic";
        private readonly IEnumerable<string> types = new[] { sspstatementissue, controlobjective, mitigation, finding, historic };

        public ObservationFaker()
        {            
            
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.Title, f => f.Lorem.Title());
            RuleFor(c => c.Description, f => f.Lorem.Paragraph());
            RuleFor(c => c.Methods, f => f.Make(3, () => f.Random.Word()));
            //RuleFor(c => c.Types , f => f.PickRandomParam(types));
            RuleFor(c => c.Types, f => f.Make(3, () => f.Lorem.Slug()));
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Origins, f => new OriginFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Subjects, f => new SubjectReferenceFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.RelevantEvidence, f => new RelevantEvidenceFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
            RuleFor(h => h.Collected, f => f.Date.Past());
            RuleFor(h => h.Expires, f => f.Date.Future());
        }
                
    }
}
