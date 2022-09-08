using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class AuthorizedPrivilege
    {
        public AuthorizedPrivilege()
        {
            FunctionsPerformed = new List<string>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> FunctionsPerformed { get; set; }
        
    }
}
