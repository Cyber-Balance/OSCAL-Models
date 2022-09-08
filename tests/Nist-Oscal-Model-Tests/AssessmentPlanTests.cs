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
    public class AssessmentPlanTests
    {
        private readonly ILogger testOutput;
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public AssessmentPlanTests(ITestOutputHelper output)
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
                       .WithOverride(_ => new Bogus.ExternalIdentifierFaker().Generate())
                       .WithOverride(_ => new Bogus.PropFaker().Generate())
                       .WithOverride(_ => new Bogus.LinkFaker().Generate())
                       ;
                ;
            });
        }

        //[Theory, OscalAutoData]
        //public void AssessmentPlanModel_ShouldSerializeSuccessfully_FromTestData([Frozen] Models.AssessmentPlan.AssessmentPlanDocument assessmentPlanDocument)
        //{
        //    assessmentPlanDocument.Should().NotBeNull();
        //    var json = JsonConvert.SerializeObject(assessmentPlanDocument, jsonSerializerSettings);
        //    json.Should().NotBeNullOrWhiteSpace();
        //    testOutput.Information(json);

        //    var copyOfAssessmentPlan = JsonConvert.DeserializeObject<Models.AssessmentPlan.AssessmentPlanDocument>(json, jsonSerializerSettings);
        //    copyOfAssessmentPlan.Should().BeEquivalentTo(assessmentPlanDocument);
        //}


        [Fact]
        public void AssessmentPlanModel_ShouldSerializeSuccessfully_FromBogusData()
        {
            var assessmentPlanDocument = new Bogus.AssessmentPlanDocumentFaker().Generate();

            assessmentPlanDocument.Should().NotBeNull();
            var json = JsonConvert.SerializeObject(assessmentPlanDocument, jsonSerializerSettings);
            json.Should().NotBeNullOrWhiteSpace();

            testOutput.Information(json);

            var copyOfassessmentPlan = JsonConvert.DeserializeObject<Models.AssessmentPlan.AssessmentPlanDocument>(json, jsonSerializerSettings);
            copyOfassessmentPlan.Should().BeEquivalentTo(assessmentPlanDocument, options =>
            {
                options.EnumerableIsNullEmptyOrExpectation<Models.AssessmentPlan.AssessmentPlanDocument, string>();

                return options;
            });
        }
    }
}
