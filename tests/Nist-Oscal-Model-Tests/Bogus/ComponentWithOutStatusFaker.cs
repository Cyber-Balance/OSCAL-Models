using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ComponentWithOutStatusFaker : AutoFaker<Models.ComponentDefinition.DefinedComponent>
    {
        private const string interconnection = "interconnection";
        private const string software = "software";
        private const string hardware = "hardware";
        private const string service = "service";
        private const string policy = "policy";
        private const string physical = "physical";
        private const string process_procedure = "process-procedure";
        private const string plan = "plan";
        private const string guidance = "guidance";
        private const string standard = "standard";
        private const string validation = "validation";
        private static readonly string[] all_types = new[] { interconnection, software, hardware, service, policy, physical, process_procedure, plan, guidance, standard, validation };

        public ComponentWithOutStatusFaker()
        {
            RuleFor(c => c.Uuid, f => f.Random.UuidV4());
            RuleFor(c => c.Type, f => f.PickRandom(Enumerable.Concat(all_types, new[] { f.Lorem.Word().ToLower() })));
            RuleFor(c => c.Title, f => f.Lorem.Title());
            RuleFor(c => c.Description, f => f.Lorem.Paragraph());
            RuleFor(c => c.Purpose, f => f.Lorem.Sentence().OrDefault(f, 0.5f));
            RuleFor(c => c.Protocols, (f, c) => c.Type == service ? new ProtocolFaker().GenerateBetween(1, 3) : Enumerable.Empty<Models.Core.Protocol>().ToList());

            RuleFor(c => c.Props, (f, u) =>
            {
                var ruleset = u.Type switch
                {
                    hardware => BogusExtensions.AssetRuleSet,
                    software => BogusExtensions.SoftwareRuleSet,
                    validation => BogusExtensions.ValidationRuleSet,
                    _ => BogusExtensions.ComponentRuleSet
                };

                return new PropFaker().GenerateBetween(1, 3, $"{BogusExtensions.DefaultRuleSet},{ruleset}").OrEmptyList(f, 0.5f);
            });

            RuleFor(c => c.Links, f => new LinkFaker().GenerateBetween(1, 3, $"{BogusExtensions.DefaultRuleSet},{BogusExtensions.ComponentRuleSet}").OrEmptyList(f, 0.5f));

            RuleFor(c => c.ControlImplementations, f => new ControlImplementationFaker().GenerateBetween(1, 2).OrEmptyList(f, 0.5f));

            RuleFor(c => c.ResponsibleRoles, f => new ResponsibleRoleFaker().GenerateBetween(1, 2, $"{BogusExtensions.DefaultRuleSet},{BogusExtensions.ResponsibleRoleRuleSet}").OrEmptyList(f, 0.5f));

            RuleFor(p => p.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
        }
    }
}
