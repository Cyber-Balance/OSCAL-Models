using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Text.Json.Newtonsoft
{
    public class OscalJsonSerializerSettings : JsonSerializerSettings
    {
        public OscalJsonSerializerSettings()
        {
            ContractResolver = new OscalJsonContractResolver();
            NullValueHandling = NullValueHandling.Ignore;
        }
    }
}
