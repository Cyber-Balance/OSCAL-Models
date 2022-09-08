using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    class EntryCoreFaker : AutoFaker<Models.Core.Entry>
    {
        public EntryCoreFaker()
        {
            RuleFor(l => l.Uuid, f => f.Random.UuidV4());
            RuleFor(l => l.Title, f => f.Lorem.Title());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
            RuleFor(h => h.Start, f => f.Date.Past());
            RuleFor(h => h.End, f => f.Date.Future());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.LoggedBy, f => new LoggedByFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.RelatedResponses, f => new RelatedResponseFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.StatusChange, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}
