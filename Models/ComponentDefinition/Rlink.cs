using System.Collections.Generic;

namespace Nist.Oscal.Models.ComponentDefinition
{
    public class Rlink
    {
        public Rlink()
        {
            Hashes = new List<Hash>();
        }

        public string Href { get; set; }
        public string MediaType { get; set; }
        public List<Hash> Hashes { get; set; }
    }
}