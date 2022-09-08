using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using AutoBogus;
using Bogus.Extensions;
using System.Linq;
using Bogus;

namespace Nist.Oscal.Tests.Bogus
{
    public class OnDateFaker : AutoFaker<Models.Core.OnDate>
    {
        public OnDateFaker()
        { 
            RuleFor(m => m.Date, f => f.Date.Recent());
        }
    }
}
