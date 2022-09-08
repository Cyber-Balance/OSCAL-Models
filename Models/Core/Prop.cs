using System;

namespace Nist.Oscal.Models.Core
{
    public class Prop 
    {
        public const string DefaultNamespace = "http://csrc.nist.gov/ns/oscal";

        public string Name { get; set; }
        public Guid? Uuid { get; set; }
        public string Ns { get; set; }
        public string Value { get; set; }
        public string Class { get; set; }
        public string Remarks { get; set; }
    }
}

