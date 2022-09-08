using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class RelatedTaskFaker : AutoFaker<Models.Core.RelatedTask>
    {
        public RelatedTaskFaker()
        {
            RuleFor(l => l.TaskUuid, f => f.Random.UuidV4());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ResponsibleParties, f => new ResponsiblePartyFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Subjects, f => new AssessmentSubjectFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
