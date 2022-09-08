using AutoBogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class SystemSecurityPlanDocumentFaker : AutoFaker<Models.SystemSecurityPlan.SystemSecurityPlanDocument>
    {
        public SystemSecurityPlanDocumentFaker()
        {
            RuleFor(d => d.SystemSecurityPlan, f => new SystemSecurityPlanFaker().Generate());
        }
    }
}