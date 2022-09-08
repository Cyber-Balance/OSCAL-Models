using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class SystemCharacteristicsFaker : AutoFaker<Models.SystemSecurityPlan.SystemCharacteristics>
    {
        //public DateTime dateAuthorized = new DateTime(2020, 01, 01);
        public SystemCharacteristicsFaker()
        {

            RuleFor(l => l.SystemIds, f => new SystemIdFaker().GenerateBetween(1, 3));
            RuleFor(r => r.SystemName, f => f.Lorem.Paragraph());
            RuleFor(r => r.SystemNameShort, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.Description, f => f.Lorem.Paragraph());


            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(h => h.DateAuthorized, f => f.Date.Past().Date);
            RuleFor(r => r.SecuritySensitivityLevel, f => f.Lorem.Paragraph()); 
            RuleFor(c => c.SystemInformation, f => new SystemInformationFaker().Generate());
            RuleFor(c => c.SecurityImpactLevel, f => new SecurityImpactLevelFaker().Generate());
            RuleFor(c => c.Status, f => new StatusFaker().Generate());
            RuleFor(c => c.AuthorizationBoundary, f => new AuthorizationBoundaryFaker().Generate());
            RuleFor(c => c.NetworkArchitecture, f => new NetworkArchitectureFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(c => c.DataFlow, f => new DataFlowFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(l => l.ResponsibleParties, f => new ResponsiblePartyFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));

            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
