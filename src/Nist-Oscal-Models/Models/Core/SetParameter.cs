using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class SetParameter
    {
        public SetParameter()
        {
            Values = new List<string>();
        }

        public string ParamId { get; set; }
        public List<string> Values { get; set; }
        public string Remarks { get; set; }
    }
}