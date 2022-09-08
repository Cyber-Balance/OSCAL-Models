using System;
using Bogus;
using System.Collections.Generic;
using System.Text;
using AutoBogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class RlinkFaker : AutoFaker<Models.ComponentDefinition.Rlink>
    {
        public RlinkFaker()
        { 
            RuleFor(r => r.MediaType, f => f.MediaTypes().MediaType().OrDefault(f, 0.5f));
            RuleFor(r => r.Href, (f, r) => f.Internet.UrlWithPath(null, null, f.MediaTypes().FileExtension(r.MediaType)));
            RuleFor(r => r.Hashes, f => new HashFaker().Generate(1).OrEmptyList(f, 0.5f));
        }
    }
}
