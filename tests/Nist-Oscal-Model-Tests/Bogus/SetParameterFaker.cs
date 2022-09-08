using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class SetParameterFaker : AutoFaker<Models.Core.SetParameter>
    {
        public SetParameterFaker()
        {
            RuleFor(p => p.ParamId, f => f.Lorem.Slug());
            RuleFor(p => p.Values, f => f.Make(f.Random.WeightedRandom(new[] { 1, 2 }, new[] { 0.75f, 0.25f }), () => f.Lorem.Word()));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}