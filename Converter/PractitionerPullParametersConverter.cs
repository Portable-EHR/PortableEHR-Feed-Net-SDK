// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Network.Server.Request.Practitioner;

namespace PortableEHRNetSDK.Converter
{
    public class PractitionerPullParametersConverter : JsonConverter<PractitionerPullParameters>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(PractitionerPullParameters).IsAssignableFrom(typeToConvert);
        }

        public override PractitionerPullParameters?
            Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Check for null values
            if (reader.TokenType == JsonTokenType.Null) return null;

            // Copy the current state from reader (it's a struct)
            var readerAtStart = reader;

            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            var jsonObject = jsonDocument.RootElement;
            JsonElement outElement = new();

            // Deserialize it
            if (jsonObject.TryGetProperty("feedItemId", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(PractitionerPullSingleParameters), options)
                    as PractitionerPullSingleParameters;
            if (jsonObject.TryGetProperty("since", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(PractitionerPullBundleParameters), options)
                    as PractitionerPullBundleParameters;

            throw new NotSupportedException("JsonObject can not be deserialized to PractitionerPullParameters");
        }

        public override void Write(Utf8JsonWriter writer, PractitionerPullParameters value,
            JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}