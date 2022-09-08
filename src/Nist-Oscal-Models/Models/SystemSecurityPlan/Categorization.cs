using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class Categorization
    {
        public Categorization()
        {
            InformationTypeIds = new List<string>();
        }
        public string System { get; set; }
        public List<string> InformationTypeIds { get; set; }
    }
}
