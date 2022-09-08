using AutoBogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class TimingFaker : AutoFaker<Models.Core.Timing>
    {
        public TimingFaker()
        {
            RuleFor(d => d.OnDate, f => new OnDateFaker().Generate());
            RuleFor(d => d.WithinDateRange, f => new DateRangeFaker().Generate());
            RuleFor(d => d.AtFrequency, f => new AtFrequencyFaker().Generate());
        }
    }
}
