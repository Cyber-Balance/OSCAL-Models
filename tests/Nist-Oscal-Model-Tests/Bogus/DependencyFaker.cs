using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class DependencyFaker : AutoFaker<Models.Core.Dependency>
    {
        public DependencyFaker()
        {
            RuleFor(c => c.TaskUuid, f => f.Random.UuidV4());
            RuleFor(m => m.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
