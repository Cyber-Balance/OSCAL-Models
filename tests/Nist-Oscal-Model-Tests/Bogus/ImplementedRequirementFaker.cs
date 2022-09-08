using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ImplementedRequirementFaker : AutoFaker<Models.ComponentDefinition.ImplementedRequirement>
    {
        public ImplementedRequirementFaker()
        {
            RuleFor(r => r.Uuid, f => f.Random.UuidV4());
            RuleFor(r => r.ControlId, f => f.Lorem.Slug());
            RuleFor(r => r.Description, f => f.Lorem.Paragraph());
            RuleFor(r => r.Props, f => f.CreateListOrEmpty<Models.Core.Prop>());
            RuleFor(r => r.Links, f => f.CreateListOrEmpty<Models.Core.Link>());
            RuleFor(r => r.SetParameters, f => new SetParameterFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ResponsibleRoles, f => new ResponsibleRoleFaker().GenerateBetween(1, 2, $"{BogusExtensions.DefaultRuleSet},{BogusExtensions.ResponsibleRoleRuleSet}").OrEmptyList(f, 0.5f));
            RuleFor(r => r.Statements, f => new StatementFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}