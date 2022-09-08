using AutoBogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class AtFrequencyFaker : AutoFaker<Models.Core.AtFrequency>
    {
        private const string seconds = "seconds";
        private const string minutes = "minutes";
        private const string hours = "hours";
        private const string days = "days";
        private const string months = "months";
        private const string years = "years";
        private static readonly string[] Units = new[] { seconds, minutes, hours, days, months, years };

        public AtFrequencyFaker()
        {
            RuleFor(m => m.Period, f => f.Random.Int(1, 100));
            //RuleFor(m => m.Unit, f => f.PickRandom(Enumerable.Concat(Units, new[] { f.Lorem.Word().ToLower() })));
            RuleFor(m => m.Unit, f => f.PickRandom(Units));
        }
    }
}
