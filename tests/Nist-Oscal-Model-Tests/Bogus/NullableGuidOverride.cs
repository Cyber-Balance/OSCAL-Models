using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;
using Bogus;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class NullableGuidOverride : AutoGeneratorOverride
    {
        public override bool Preinitialize => false;

        public override bool CanOverride(AutoGenerateContext context)
        {
            return context.GenerateType == typeof(Guid?);
        }

        public override void Generate(AutoGenerateOverrideContext context)
        {
            context.Instance = context.Faker.Random.UuidV4().OrNull(context.Faker, 0.5f);
        }
    }
}
