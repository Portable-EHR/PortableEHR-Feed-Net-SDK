// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Model;

namespace PortableEHRNetSDK.Converter
{
    public class CountryEnumConverter : JsonConverter<CountryEnum>
    {
        public override CountryEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return CountryEnum.GetFromValue(value);
        }

        public override void Write(Utf8JsonWriter writer, CountryEnum myEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(myEnum.Value);
        }
    }
}