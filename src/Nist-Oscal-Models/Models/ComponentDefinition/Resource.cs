using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.ComponentDefinition
{
    public class Resource
    {
        public Resource()
        {
            Props = new List<Prop>();
            DocumentIds = new List<DocumentId>();
            Rlinks = new List<Rlink>();
        }

        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<DocumentId> DocumentIds { get; set; }
        public Citation Citation { get; set; }
        public List<Rlink> Rlinks { get; set; }
        public Base64 Base64 { get; set; }
        public string Remarks { get; set; }
    }
}