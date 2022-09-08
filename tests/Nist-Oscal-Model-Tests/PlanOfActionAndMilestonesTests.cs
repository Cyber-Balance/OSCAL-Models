using FluentAssertions;
using Serilog;
using Xunit;
using Xunit.Abstractions;
using Newtonsoft.Json;
using Nist.Oscal.Text.Json.Newtonsoft;
using FluentAssertions.Json;
using AutoBogus;

namespace Nist.Oscal.Tests
{
    public class PlanOfActionAndMilestonesTests
    {
        private readonly ILogger testOutput;
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public PlanOfActionAndMilestonesTests(ITestOutputHelper output)
        {
            testOutput = new LoggerConfiguration()
                            .WriteTo.TestOutput(output)
                            .CreateLogger();

            jsonSerializerSettings = new OscalJsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new[] { new OscalJsonConverter() }
            };

            AutoFaker.Configure(builder =>
            {
                builder.WithLocale("en")
                        .WithRecursiveDepth(0)
                       ;
                ;
            });
        }

        [Fact]
        public void PlanOfActionAndMilestonesModel_ShouldSerializeSuccessfully_FromBogusData()
        {
            var planOfActionAndMilestonesDocument = new Bogus.PlanOfActionAndMilestonesDocumentFaker().Generate();

            planOfActionAndMilestonesDocument.Should().NotBeNull();
            var json = JsonConvert.SerializeObject(planOfActionAndMilestonesDocument, jsonSerializerSettings);
            json.Should().NotBeNullOrWhiteSpace();

            testOutput.Information(json);

            var copyOfplanOfActionAndMilestones = JsonConvert.DeserializeObject<Models.PlanOfActionAndMilestones.PlanOfActionAndMilestonesDocument>(json, jsonSerializerSettings);
            copyOfplanOfActionAndMilestones.Should().BeEquivalentTo(planOfActionAndMilestonesDocument, options =>
            {
                options.EnumerableIsNullEmptyOrExpectation<Models.PlanOfActionAndMilestones.PlanOfActionAndMilestonesDocument, string>();

                return options;
            });
        }
    }
}
