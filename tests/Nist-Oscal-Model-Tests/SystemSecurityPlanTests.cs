using AutoBogus;
using AutoFixture.Xunit2;
using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nist.Oscal.Text.Json.Newtonsoft;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;


namespace Nist.Oscal.Tests
{
    public class SystemSecurityPlanTests
    {
        private readonly ILogger testOutput;
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public SystemSecurityPlanTests(ITestOutputHelper output)
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

        //[Theory]
        //[InlineData("https://raw.githubusercontent.com/usnistgov/oscal-content/master/examples/ssp/json/ssp-example.json")]
        //public async Task SystemSecurityPlanModel_ShouldDeserializeSuccessfully_WhenUsingNistExampleContent(string contentUrl)
        //{
        //    contentUrl.Should().NotBeNullOrWhiteSpace();

        //    using var http = new HttpClient();
            
        //    testOutput.Information("Requesting OSCAL content from {ContentUrl}", contentUrl);
        //    var responseMessage = await http.GetAsync(contentUrl);
        //    responseMessage.EnsureSuccessStatusCode();

        //    var httpContent = await responseMessage.Content.ReadAsStringAsync();
        //    httpContent.Should().NotBeNullOrWhiteSpace();
        //    testOutput.Information(httpContent);

        //    var ssp = JsonConvert.DeserializeObject<Models.SystemSecurityPlan.SystemSecurityPlanDocument>(httpContent, jsonSerializerSettings);
        //    ssp.Should().NotBeNull();

        //    var sspInJson = JsonConvert.SerializeObject(ssp, jsonSerializerSettings);
        //    sspInJson.Should().NotBeNullOrWhiteSpace();

        //    var jsonContent = JObject.Parse(httpContent);
        //    var jsonObject = JObject.Parse(sspInJson);

        //    jsonContent.Should().BeEquivalentTo(jsonObject);
        //}

        //[Theory, OscalAutoData]
        //public void SystemSecurityPlanModel_ShouldSerializeSuccessfully_FromTestData([Frozen] Models.SystemSecurityPlan.SystemSecurityPlanDocument systemSecurityPlanDocument)
        //{
        //    systemSecurityPlanDocument.Should().NotBeNull();
        //    var json = JsonConvert.SerializeObject(systemSecurityPlanDocument, jsonSerializerSettings);
        //    json.Should().NotBeNullOrWhiteSpace();
        //    testOutput.Information(json);

        //    var copyOfComponentDefinition = JsonConvert.DeserializeObject<Models.SystemSecurityPlan.SystemSecurityPlanDocument>(json, jsonSerializerSettings);
        //    copyOfComponentDefinition.Should().BeEquivalentTo(systemSecurityPlanDocument);
        //}

        [Fact]
        public void SystemSecurityPlanModel_ShouldSerializeSuccessfully_FromBogusData()
        {
            var systemSecurityPlanDocument = new Bogus.SystemSecurityPlanDocumentFaker().Generate();

            systemSecurityPlanDocument.Should().NotBeNull();
            var json = JsonConvert.SerializeObject(systemSecurityPlanDocument, jsonSerializerSettings);
            json.Should().NotBeNullOrWhiteSpace();

            testOutput.Information(json);

            var copyOfystemSecurityPlan = JsonConvert.DeserializeObject<Models.SystemSecurityPlan.SystemSecurityPlanDocument>(json, jsonSerializerSettings);
            copyOfystemSecurityPlan.Should().BeEquivalentTo(systemSecurityPlanDocument, options =>
            {
                options.EnumerableIsNullEmptyOrExpectation<Models.SystemSecurityPlan.SystemSecurityPlanDocument, string>();

                return options;
            });

            File.WriteAllText(Path.GetRandomFileName(), json);

        }

    }
}
      

