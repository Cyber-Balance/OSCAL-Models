﻿using Nist.Oscal.Models.Core;
using System;
using System.Collections.Generic;

namespace Nist.Oscal.Models.Core
{
    public class Component
    {
        public Component()
        {
            Props = new List<Prop>();
            Links = new List<Link>();
            ResponsibleRoles = new List<ResponsibleRole>();
            Protocols = new List<Protocol>();
            //ControlImplementations = new List<ControlImplementation>();
        }

        public Guid Uuid { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public List<ResponsibleRole> ResponsibleRoles { get; set; }
        public Status Status { get; set; }
        public List<Protocol> Protocols { get; set; }
        //public List<ControlImplementation> ControlImplementations { get; set; }
        public string Remarks { get; set; }
    }
}
