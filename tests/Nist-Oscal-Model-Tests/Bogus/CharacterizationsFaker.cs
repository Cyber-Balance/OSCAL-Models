using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class CharacterizationsFaker :  AutoFaker<Models.Core.Characterizations>
    {
        public CharacterizationsFaker()
        {
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Origin, f => new OriginFaker().Generate());
            RuleFor(r => r.Facets, f => new FacetFaker().GenerateBetween(1, 3));
        }
    }
}
