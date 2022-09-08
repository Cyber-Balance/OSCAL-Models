using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class LinkFaker : AutoFaker<Models.Core.Link>
    {
        private const string dependson = "depends-on";
        private const string validation = "validation";
        private const string proofofcompliance = "proof-of-compliance";
        private const string baselinetemplate = "baseline-template";
        private const string usesservice = "uses-service";
        private const string systemsecurityplan = "system-security-plan";
        private const string usesnetwork = "uses-network";

        private const string providedby = "provided-by";
        private const string usedby = "used-by";

        private readonly string[] allcomponentrelations = new[] { dependson, validation, proofofcompliance, baselinetemplate, usesservice, usesnetwork, systemsecurityplan };

        public LinkFaker()
        { 
            RuleFor(l => l.Rel, f => "reference".OrDefault(f, 0.5f));
            RuleFor(l => l.MediaType, f => f.MediaTypes().MediaType().Trim().OrDefault(f, 0.5f));
            RuleFor(l => l.Href, (f, l) => f.Internet.UrlWithPath(null, null, f.MediaTypes().FileExtension(l.MediaType)));
            RuleFor(l => l.Text, f => f.Lorem.Text().OrDefault(f, 0.75f));

            RuleSet(BogusExtensions.ComponentRuleSet, rules =>
            {
                RuleFor(l => l.Rel, f => f.PickRandom(allcomponentrelations).OrDefault(f, 0.25f));
            });

            RuleSet(BogusExtensions.ServiceRuleSet, rules =>
            {
                RuleFor(l => l.Rel, f => f.PickRandom(providedby, usedby).OrDefault(f, 0.25f));
            });
        }
    }
}
