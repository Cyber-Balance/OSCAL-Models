using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class IdentifiedSubjectFaker : AutoFaker<Models.Core.IdentifiedSubject>
    {
        public IdentifiedSubjectFaker()
        { 
            RuleFor(l => l.SubjectPlaceholderUuid, f => f.Random.UuidV4());
            RuleFor(r => r.Subjects, f => new AssessmentSubjectFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
