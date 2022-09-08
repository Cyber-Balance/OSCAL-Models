using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class AssociatedActivityFaker : AutoFaker<Models.Core.AssociatedActivity>
    {
        public AssociatedActivityFaker()
        {
            RuleFor(s => s.ActivityUuid, f => f.Random.UuidV4());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ResponsibleRoles, f => new ResponsibleRoleFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Subjects, f => new AssessmentSubjectFaker().GenerateBetween(1, 3));
            RuleFor(m => m.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
