// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Network;

namespace PortableEHRNetSDK.Converter
{
    public class ApiStatusEnumConverter : JsonConverter<ApiStatusEnum>
    {
        public override ApiStatusEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return ApiStatusEnum.GetFromValue(value);
        }

        public override void Write(Utf8JsonWriter writer, ApiStatusEnum myEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(myEnum.Value);
        }
    }
}