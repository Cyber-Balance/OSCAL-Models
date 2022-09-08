using System;
using System.Text;
using AutoBogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class HashFaker : AutoFaker<Models.ComponentDefinition.Hash>
    {
        private const string sha256 = "SHA-256";
        private const string sha384 = "SHA-384";
        private const string sha512 = "SHA-512";

        public HashFaker()
        {
            RuleFor(h => h.Algorithm, f => f.PickRandom(sha256, sha384, sha512));
            RuleFor(h => h.Value, (f, h) => CreateHash(h.Algorithm, f.Lorem.Paragraph()));
        }

        private static string CreateHash(string algorithm, string text)
        {
            var hasher = System.Security.Cryptography.HashAlgorithm.Create(algorithm);
            return Convert.ToBase64String(hasher.ComputeHash(Encoding.UTF8.GetBytes(text)));
        }
    }
}
