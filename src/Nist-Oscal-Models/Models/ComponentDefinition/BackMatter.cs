using System.Collections.Generic;

namespace Nist.Oscal.Models.ComponentDefinition
{
    public class BackMatter
    {
        public BackMatter()
        {
            Resources = new List<Resource>();
        }

        public List<Resource> Resources { get; set; }
    }
}