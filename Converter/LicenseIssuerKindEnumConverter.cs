// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Model.Server;

namespace PortableEHRNetSDK.Converter
{
    public class LicenseIssuerKindEnumConverter : JsonConverter<LicenseIssuerKindEnum>
    {
        public override LicenseIssuerKindEnum Read(ref Utf8JsonReader reader, Type typeToConvert,
            JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return LicenseIssuerKindEnum.GetFromValue(value);
        }

        public override void Write(Utf8JsonWriter writer, LicenseIssuerKindEnum myEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(myEnum.Value);
        }
    }
}