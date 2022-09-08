using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class RiskLog
    {
        public RiskLog()
        {
            Entries = new List<Entry>();
        }
        public List<Entry> Entries { get; set; }
    }
}
