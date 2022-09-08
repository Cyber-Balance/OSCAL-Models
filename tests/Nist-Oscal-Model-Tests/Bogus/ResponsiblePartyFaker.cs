using System;
using System.Collections.Generic;
using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class ResponsiblePartyFaker : AutoFaker<Models.Core.ResponsibleParty>
    {
        private string roleId = null;
        private readonly List<Guid> partyUuids = new List<Guid>();

        public ResponsiblePartyFaker()
        {
            RuleFor(r => r.RoleId, f => roleId ?? f.Lorem.Slug());
            RuleFor(r => r.PartyUuids, f => f.Make(f.Random.Int(1, 2), _ => f.Random.UuidV4()));
            //RuleFor(p => p.Props, (f, u) => f.CreateListOrEmpty<Models.Core.Prop>(1, 2));
            RuleFor(p => p.Props, f => new PropFaker().GenerateBetween(1, 3));
            RuleFor(p => p.Links, f => new LinkFaker().GenerateBetween(1, 3));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }

        public ResponsiblePartyFaker WithRoleId(string id)
        {
            roleId = id;
            return this;
        }

        public ResponsiblePartyFaker WithPartyUuids(IEnumerable<Guid> uuids)
        {
            partyUuids.AddRange(uuids);
            return this;
        }
    }
}