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
    public class AssessmentResultsTests
    {
        private readonly ILogger testOutput;
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public AssessmentResultsTests(ITestOutputHelper output)
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
                       //.WithOverride(_ => new Bogus.ExternalIdentifierFaker().Generate())
                       //.WithOverride(_ => new Bogus.PropFaker().Generate())
                       //.WithOverride(_ => new Bogus.LinkFaker().Generate())
                       ;
                ;
            });
        }


        //[Theory, OscalAutoData]
        //public void AssessmentResultsModel_ShouldSerializeSuccessfully_FromTestData([Frozen] Models.AssessmentResults.AssessmentResultsDocument assessmentResultsDocument)
        //{
        //    assessmentResultsDocument.Should().NotBeNull();
        //    var json = JsonConvert.SerializeObject(assessmentResultsDocument, jsonSerializerSettings);
        //    json.Should().NotBeNullOrWhiteSpace();
        //    testOutput.Information(json);

        //    var copyOfAssessmentResults = JsonConvert.DeserializeObject<Models.AssessmentResults.AssessmentResultsDocument>(json, jsonSerializerSettings);
        //    copyOfAssessmentResults.Should().BeEquivalentTo(assessmentResultsDocument);
        //}


        [Fact]
        public void AssessmentResultsModel_ShouldSerializeSuccessfully_FromBogusData()
        {
            var assessmentResultsDocument = new Bogus.AssessmentResultsDocumentFaker().Generate();

            assessmentResultsDocument.Should().NotBeNull();
            var json = JsonConvert.SerializeObject(assessmentResultsDocument, jsonSerializerSettings);
            json.Should().NotBeNullOrWhiteSpace();

            testOutput.Information(json);

            var copyOfassessmentResults = JsonConvert.DeserializeObject<Models.AssessmentResults.AssessmentResultsDocument>(json, jsonSerializerSettings);
            copyOfassessmentResults.Should().BeEquivalentTo(assessmentResultsDocument, options =>
            {
                options.EnumerableIsNullEmptyOrExpectation<Models.AssessmentResults.AssessmentResultsDocument, string>();

                return options;
            });
        }
    }
}
