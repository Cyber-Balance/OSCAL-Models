using FluentAssertions;
using Serilog;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Newtonsoft.Json;
using Nist.Oscal.Text.Json.Newtonsoft;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using AutoBogus;
using System.Collections.Generic;
using FluentAssertions.Equivalency;

namespace Nist.Oscal.Tests
{
    public class ComponentDefinitionTests
    {
        private readonly ILogger testOutput;
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public ComponentDefinitionTests(ITestOutputHelper output)
        {
            testOutput = new LoggerConfiguration()
                            .WriteTo.TestOutput(output)
                            .CreateLogger();

            jsonSerializerSettings = new OscalJsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new [] { new OscalJsonConverter() }
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

        [Theory]
        [InlineData("https://raw.githubusercontent.com/usnistgov/oscal-content/master/examples/component-definition/json/example-component-definition.json")]
        public async Task ComponentModel_ShouldDeserializeSuccessfully_WhenUsingNistExampleContent(string contentUrl)
        {
            contentUrl.Should().NotBeNullOrWhiteSpace();

            using var http = new HttpClient();

            testOutput.Information("Requesting OSCAL content from {ContentUrl}", contentUrl);
            var responseMessage = await http.GetAsync(contentUrl);
            responseMessage.EnsureSuccessStatusCode();

            var httpContent = await responseMessage.Content.ReadAsStringAsync();
            httpContent.Should().NotBeNullOrWhiteSpace();
            testOutput.Information(httpContent);

            var componentDefinition = JsonConvert.DeserializeObject<Models.ComponentDefinition.ComponentDefinitionDocument>(httpContent, jsonSerializerSettings);
            componentDefinition.Should().NotBeNull();

            var componentDefinitionInJson = JsonConvert.SerializeObject(componentDefinition, jsonSerializerSettings);
            componentDefinitionInJson.Should().NotBeNullOrWhiteSpace();

            var jsonContent = JObject.Parse(httpContent);
            var jsonObject = JObject.Parse(componentDefinitionInJson);

            jsonContent.Should().BeEquivalentTo(jsonObject);
        }

        //[Theory, OscalAutoData]
        //public void ComponentModel_ShouldSerializeSuccessfully_FromTestData([Frozen] Models.ComponentDefinition.ComponentDefinitionDocument componentDefinitionDocument)
        //{
        //    componentDefinitionDocument.Should().NotBeNull();
        //    var json = JsonConvert.SerializeObject(componentDefinitionDocument, jsonSerializerSettings);
        //    json.Should().NotBeNullOrWhiteSpace();
        //    testOutput.Information(json);

        //    var copyOfComponentDefinition = JsonConvert.DeserializeObject<Models.ComponentDefinition.ComponentDefinitionDocument>(json, jsonSerializerSettings);
        //    copyOfComponentDefinition.Should().BeEquivalentTo(componentDefinitionDocument);
        //}

        [Fact]
        public void ComponentModel_ShouldSerializeSuccessfully_FromBogusData()
        {
            var componentDefinitionDocument = new Bogus.ComponentDocumentDefinitionFaker().Generate();

            componentDefinitionDocument.Should().NotBeNull();
            var json = JsonConvert.SerializeObject(componentDefinitionDocument, jsonSerializerSettings);
            json.Should().NotBeNullOrWhiteSpace();

            testOutput.Information(json);

            var copyOfComponentDefinition = JsonConvert.DeserializeObject<Models.ComponentDefinition.ComponentDefinitionDocument>(json, jsonSerializerSettings);
            copyOfComponentDefinition.Should().BeEquivalentTo(componentDefinitionDocument, options =>
            {
                //options.EnumerableIsNullEmptyOrExpectation<Models.ComponentDefinition.ComponentDefinitionDocument, Models.Core.Prop>();
                //options.EnumerableIsNullEmptyOrExpectation<Models.ComponentDefinition.ComponentDefinitionDocument, Models.ComponentDefinition.Rlink>();
                options.EnumerableIsNullEmptyOrExpectation<Models.ComponentDefinition.ComponentDefinitionDocument, string>();

                return options;
            });
        }
    }

    public static class AssertionHelper
    {
        public static void EnumerableIsNullEmptyOrExpectation<TExpectation, T>(this EquivalencyAssertionOptions<TExpectation> options)
        {
            options.Using<IEnumerable<T>>(x =>
            {
                if (x.Expectation == null)
                {
                    x.Subject.Should().BeNullOrEmpty();
                }
                else
                {
                    x.Subject.Should().BeEquivalentTo(x.Expectation);
                }
            }).WhenTypeIs<IEnumerable<T>>();
        }
    }
}
