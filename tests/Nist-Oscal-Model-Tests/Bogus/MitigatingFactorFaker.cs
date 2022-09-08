using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class MitigatingFactorFaker : AutoFaker<Models.Core.MitigatingFactor>
    {
        public MitigatingFactorFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.ImplementationUuid, f => f.Random.UuidV4());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Subjects, f => new SubjectReferenceFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
        }
    }
}
