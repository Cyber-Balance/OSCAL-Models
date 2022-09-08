using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Nist.Oscal.Text.Json.Newtonsoft
{
    public class OscalJsonConverter : JsonConverter
    {
        private readonly IEnumerable<Type> types;
        private readonly JsonSerializer jsonSerializer;

        public OscalJsonConverter()
        {
            types = GetOscalModels(GetType().Assembly);
            jsonSerializer = JsonSerializer.CreateDefault(new OscalJsonSerializerSettings());
        }

        public OscalJsonConverter(JsonSerializerSettings jsonSerializerSettings)
        {
            types = GetOscalModels(GetType().Assembly);
            jsonSerializer = JsonSerializer.Create(jsonSerializerSettings);
        }

        public OscalJsonConverter(Assembly assembly)
        {
            types = GetOscalModels(assembly);
            jsonSerializer = JsonSerializer.CreateDefault(new OscalJsonSerializerSettings());
        }

        public OscalJsonConverter(IEnumerable<Type> types)
        {
            this.types = types;
            jsonSerializer = JsonSerializer.CreateDefault(new OscalJsonSerializerSettings());
        }

        public OscalJsonConverter(Assembly assembly, JsonSerializerSettings jsonSerializerSettings)
        {
            types = GetOscalModels(assembly);
            jsonSerializer = JsonSerializer.Create(jsonSerializerSettings);
        }

        public OscalJsonConverter(IEnumerable<Type> types, JsonSerializerSettings jsonSerializerSettings)
        {
            this.types = types;
            jsonSerializer = JsonSerializer.Create(jsonSerializerSettings);
        }

        private IEnumerable<Type> GetOscalModels(Assembly assembly)
            => assembly.GetTypes().Where(t => t.Namespace.StartsWith("Nist.Oscal.Models", StringComparison.OrdinalIgnoreCase));

        public override bool CanConvert(Type objectType)
        {
            return types.Any(t => t.IsAssignableFrom(objectType));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return jsonSerializer.Deserialize(reader, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            jsonSerializer.Serialize(writer, value);
        }
    }
}
