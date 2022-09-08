
using System;
using System.Collections.Generic;
using System.Text;
using Nist.Oscal.Models.Core;

namespace Nist.Oscal.Models.SystemSecurityPlan
{
    public class SystemCharacteristics
    {
        public SystemCharacteristics()
        {
            SystemIds = new List<SystemId>();
            Props = new List<Prop>();
            Links = new List<Link>();
            ResponsibleParties = new List<ResponsibleParty>();
        }
        public List<SystemId> SystemIds { get; set; }
        public string SystemName { get; set; }
        public string SystemNameShort { get; set; }
        public string Description { get; set; }
        public List<Prop> Props { get; set; }
        public List<Link> Links { get; set; }
        public DateTime DateAuthorized { get; set; }
        public string SecuritySensitivityLevel { get; set; }
        public SystemInformation SystemInformation { get; set; }
        public SecurityImpactLevel SecurityImpactLevel { get; set; }
        public Status Status { get; set; }
        public AuthorizationBoundary AuthorizationBoundary { get; set; }
        public NetworkArchitecture NetworkArchitecture { get; set; }
        public DataFlow DataFlow { get; set; }
        public List<ResponsibleParty> ResponsibleParties { get; set; }
        public string Remarks { get; set; }

    }
}
