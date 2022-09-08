using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Models.Core
{
    public class SubjectReference
    { 
    public SubjectReference()
    {
        Props = new List<Prop>();
        Links = new List<Link>();
    }
    public Guid SubjectUuid { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public List<Prop> Props { get; set; }
    public List<Link> Links { get; set; }
    public string Remarks { get; set; }
}
}
