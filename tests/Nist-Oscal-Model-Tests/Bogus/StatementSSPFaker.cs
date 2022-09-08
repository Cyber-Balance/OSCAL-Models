using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class StatementSSPFaker : AutoFaker<Models.SystemSecurityPlan.SspStatement>
    {
        public StatementSSPFaker()
        {
            RuleFor(s => s.StatementId, f => f.Lorem.Slug());
            RuleFor(s => s.Uuid, f => f.Random.UuidV4());
            RuleFor(s => s.Props, f => f.CreateListOrEmpty<Models.Core.Prop>());
            RuleFor(s => s.Links, f => f.CreateListOrEmpty<Models.Core.Link>());
            RuleFor(s => s.ResponsibleRoles, f => new ResponsibleRoleFaker().GenerateBetween(1, 2, $"{BogusExtensions.DefaultRuleSet},{BogusExtensions.ResponsibleRoleRuleSet}").OrEmptyList(f, 0.5f));
            RuleFor(s => s.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));
        }
    }
}