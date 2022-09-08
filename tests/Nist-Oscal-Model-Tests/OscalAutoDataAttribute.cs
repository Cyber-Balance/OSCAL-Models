using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace Nist.Oscal.Tests
{
    class OscalAutoDataAttribute : AutoDataAttribute
    {
        public OscalAutoDataAttribute()
            : base(() => Create()) { }

        public static IFixture Create()
         => new Fixture().Customize(
                new CompositeCustomization(
                    new AutoMoqCustomization
                    {
                        ConfigureMembers = true
                    },
                    new OscalDataCustomization()
               ));
    }
}

