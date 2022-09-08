using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Nist.Oscal.Text.Json.Newtonsoft
{
    public class OscalJsonContractResolver : DefaultContractResolver
    {
        public OscalJsonContractResolver()
        {
            NamingStrategy = new KebabCaseNamingStrategy();
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.PropertyType != typeof(string) 
             && typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
            {
                property.ShouldSerialize = instance =>
                {
                    IEnumerable enumerable = default;
                    // this value could be in a public field or public property
                    switch (member.MemberType)
                    {
                        case MemberTypes.Property:
                            enumerable = instance
                                            .GetType()
                                            .GetProperty(member.Name)?
                                            .GetValue(instance, default) as IEnumerable;
                            break;
                        case MemberTypes.Field:
                            enumerable = instance
                                            .GetType()
                                            .GetField(member.Name)?
                                            .GetValue(instance) as IEnumerable;
                            break;
                    }

                    return enumerable == default ||
                           enumerable.GetEnumerator().MoveNext();
                    // if the list is null, we defer the decision to NullValueHandling
                };
            }

            return property;
        }
    }
}
