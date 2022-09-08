using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class ExcludeControl
    {
        public ExcludeControl()
        {
            StatementIds = new List<string>();
        }
        public string ControlId { get; set; }
        public List<string> StatementIds { get; set; }
    }
}
