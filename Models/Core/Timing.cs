using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class Timing
    {
        public OnDate OnDate { get; set; }
        public DateRange WithinDateRange { get; set; }
        public AtFrequency AtFrequency { get; set; }
    }
}
