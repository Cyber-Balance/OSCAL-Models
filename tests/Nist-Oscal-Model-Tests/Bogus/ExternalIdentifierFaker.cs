using AutoBogus;

namespace Nist.Oscal.Tests.Bogus
{
    public class ExternalIdentifierFaker : AutoFaker<Models.Core.DocumentId>
    {
        private const string scheme = "http://www.doi.org/";
        private const string doiprefixes = "https://doi.org/";
        private const string doi = "doi:";
        private const string info = "info:doi/";
        private static readonly string[] Identifiers = { doiprefixes, doi, info }; 

        public ExternalIdentifierFaker()
        {
            RuleFor(e => e.Scheme, scheme);
            RuleFor(e => e.Identifier, f => string.Concat(f.PickRandom(Identifiers), "10.", f.Random.Int(1001, 9999), "/", f.Random.Int()));
            
        }
    }
}
