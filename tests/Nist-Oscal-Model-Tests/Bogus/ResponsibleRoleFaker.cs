using System;
using System.Collections.Generic;
using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class ResponsibleRoleFaker : AutoFaker<Models.Core.ResponsibleRole>
    {
        private const string preparedby = "prepared-by";
        private const string preparedfor = "prepared-for";
        private const string contentapprover = "content-approver";

        public ResponsibleRoleFaker()
        {
            RuleFor(r => r.RoleId, f => f.PickRandom(preparedby, preparedfor, contentapprover));
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 2, $"{BogusExtensions.DefaultRuleSet},{BogusExtensions.PersonRuleSet}").OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1,2).OrEmptyList(f, 0.5f));
            RuleFor(r => r.PartyUuids, f => f.Make(f.Random.Int(1, 2), _ => f.Random.UuidV4()));
            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
