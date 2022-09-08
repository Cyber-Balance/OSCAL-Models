using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class LoggedByFaker : AutoFaker<Models.Core.LoggedBy>
    {
        public LoggedByFaker()
        {
            RuleFor(l => l.PartyUuid, f => f.Random.UuidV4());
            RuleFor(l => l.RoleId, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
