// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Model;

namespace PortableEHRNetSDK.Converter
{
    public class IdIssuerKindEnumConverter : JsonConverter<IdIssuerKindEnum>
    {
        public override IdIssuerKindEnum Read(ref Utf8JsonReader reader, Type typeToConvert,
            JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return IdIssuerKindEnum.GetFromValue(value);
        }

        public override void Write(Utf8JsonWriter writer, IdIssuerKindEnum myEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(myEnum.Value);
        }
    }
}