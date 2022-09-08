using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class Protocol
    {
        public Protocol()
        {
            PortRanges = new List<PortRange>();
        }

        public Guid? Uuid { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public List<PortRange> PortRanges { get; set; }
    }
}
