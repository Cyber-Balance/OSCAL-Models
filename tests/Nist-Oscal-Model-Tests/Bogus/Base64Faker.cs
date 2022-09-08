using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class Base64Faker : AutoFaker<Models.ComponentDefinition.Base64>
    {
        public Base64Faker()
        { 
            RuleFor(b => b.MediaType, f => f.MediaTypes().MediaType().OrDefault(f, 0.5f));
            RuleFor(b => b.Filename, (f, b) => f.System.FileName(f.MediaTypes().FileExtension(b.MediaType)).OrDefault(f, 0.5f));
            //RuleFor(b => b.Value, (f, b) => string.IsNullOrWhiteSpace(b.Filename) ? Convert.ToBase64String(Encoding.UTF8.GetBytes(f.Lorem.Paragraph())) : default);
            RuleFor(b => b.Value, f => Convert.ToBase64String(Encoding.UTF8.GetBytes(f.Lorem.Paragraph())));
        }
    }
}
