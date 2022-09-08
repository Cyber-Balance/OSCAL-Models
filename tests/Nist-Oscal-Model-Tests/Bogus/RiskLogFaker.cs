using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class RiskLogFaker : AutoFaker<Models.Core.RiskLog>
    {
        public RiskLogFaker()
        {
            RuleFor(r => r.Entries, f => new EntryCoreFaker().GenerateBetween(1, 3));
        }
    }
}
