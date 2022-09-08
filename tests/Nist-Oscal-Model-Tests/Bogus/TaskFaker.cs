using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class TaskFaker : AutoFaker<Models.Core.Task>
    {
        private const string milestone = "milestone";
        private const string action = "action";
        public TaskFaker()
        {
            RuleFor(s => s.Uuid, f => f.Random.UuidV4());
            RuleFor(h => h.Type, f => f.PickRandom(milestone, action));
            RuleFor(h => h.Title, f => f.Lorem.Title());
            RuleFor(r => r.Props, f => new PropFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Links, f => new LinkFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Dependencies, f => new DependencyFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Subjects, f => new AssessmentSubjectFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.ResponsibleRoles, f => new ResponsibleRoleFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Timing, f => new TimingFaker().Generate().OrDefault(f, 0.5f));
            RuleFor(r => r.AssociatedActivities, f => new AssociatedActivityFaker().GenerateBetween(1, 3).OrEmptyList(f, 0.5f));
            RuleFor(r => r.Description, f => f.Lorem.Paragraph().OrDefault(f, 0.75f));
            RuleFor(m => m.Remarks, f => f.Lorem.Paragraph().OrDefault(f, 0.5f));

            RuleFor(r => r.Tasks, f => f.Make(f.Random.Int(1, 3), () =>
            {
                return new Models.Core.Task
                {
                    Uuid = f.Random.UuidV4(),
                    Type = f.PickRandom(milestone, action),
                    Title = f.Lorem.Title()
                };
            }).OrEmptyList(f, 0.5f));

            
            //RuleSet("ChildTask", rules =>
            //{
            //    RuleFor(r => r.Tasks, f => new List<Models.Core.Task>());
            //});
        }
    }
}
