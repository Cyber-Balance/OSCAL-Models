using AutoBogus;

namespace Nist.Oscal.Tests.Bogus
{
    public class ExternalIdentifierExternalIdFaker : AutoFaker<Models.Core.ExternalId>
    {
        private const string scheme = "http://orcid.org/";
        private const string ordidprefix = "https://orcid.org/0000-000";

        public ExternalIdentifierExternalIdFaker()
        {
            RuleFor(e => e.Scheme, scheme);
            RuleFor(e => e.Id, f => string.Concat(ordidprefix, f.Random.Int(150000007, 350000001).ToString("#-####-####")));
        }
    }
}