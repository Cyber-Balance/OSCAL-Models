using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;

namespace Nist.Oscal.Tests.Bogus
{
    public class DateRangeFaker : AutoFaker<Models.Core.DateRange>
    {
        public DateRangeFaker()
        {
            RuleFor(m => m.Start, f => f.Date.Past());
            RuleFor(m => m.End, f => f.Date.Future());
        }
    }

}
