using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    internal class AssessmentPartFaker : AutoFaker<Models.Core.AssessmentPart>
    {
        private const string ns= "http://csrc.nist.gov/ns/oscal";
        public AssessmentPartFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(p => p.Name, f => f.Lorem.Slug());
            RuleFor(r => r.Ns, f => ns);
            RuleFor(r => r.Class, f => f.Lorem.Slug().OrDefault(f, 0.5f));
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Title, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(r => r.Prose, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            //RuleFor(r => r.Parts, f => this.GenerateBetween(1, 3, "ChildPart").OrEmptyList(f, 0.5f));
            //RuleSet("ChildPart", rules =>
            //{
            //    RuleFor(r => r.Parts, f => new List<Models.Core.PartswithUuid>());
            //});

            RuleFor(r => r.Parts, f => new AssessmentPartFaker().GenerateBetween(1, 3, $"{BogusExtensions.DefaultRuleSet},ChildPart").OrEmptyList(f, 0.5f));
            RuleFor(r => r.Parts, f => f.Make(f.Random.Int(1, 3), () =>
            {
                return new Models.Core.AssessmentPart
                {
                    Uuid = f.Random.UuidV4(),
                    Name = f.Lorem.Slug()
                };
            }).OrEmptyList(f, 0.5f));
        }
    }
}