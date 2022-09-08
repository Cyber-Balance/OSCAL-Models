using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using AutoBogus;
using Bogus.Extensions;
using System.Linq;
using Bogus;

namespace Nist.Oscal.Tests.Bogus
{
    public class RoleFaker : AutoFaker<Models.Core.Role>
    {
        private const string assetowner = "asset-owner";
        private const string assetadministrator = "asset-administrator";
        private const string securityoperations = "security-operations";
        private const string networkoperations = "network-operations";
        private const string incidentresponse = "incident-response";
        private const string helpdesk = "help-desk";
        private const string configurationmanagement = "configuration-management";
        private const string maintainer = "maintainer";
        private const string provider = "provider";


        public RoleFaker()
        {
            RuleFor(r => r.Id, f => f.Lorem.Slug());
            RuleFor(r => r.Title, f => f.Lorem.Title());
            RuleFor(r => r.ShortName, (f, u) => string.Concat((u.Title ?? f.Lorem.Title()).Split(' ').Select(s => char.ToUpperInvariant(s[0]))));
            RuleFor(r => r.Description, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
            //RuleFor(r => r.Props, f => f.CreateListOrEmpty<Models.Core.Prop>());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f));

            RuleSet(BogusExtensions.ResponsiblePartyRuleSet, f =>
            {
                RuleFor(r => r.Id, f => f.PickRandom(assetowner, assetadministrator, securityoperations, networkoperations, incidentresponse, helpdesk, configurationmanagement, maintainer, provider));
            });
        }
    }
}
