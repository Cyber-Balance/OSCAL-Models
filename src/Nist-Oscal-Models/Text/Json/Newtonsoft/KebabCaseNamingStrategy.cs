using Newtonsoft.Json.Serialization;
using System.Text.RegularExpressions;

namespace Nist.Oscal.Text.Json.Newtonsoft
{
    public class KebabCaseNamingStrategy : NamingStrategy
    {
        protected override string ResolvePropertyName(string name)
        {
            return Regex.Replace(name, "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", "$1-").ToLowerInvariant();
        }
    }
}
