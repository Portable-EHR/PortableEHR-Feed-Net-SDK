// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Network.Server.Response.Practitioner;

namespace PortableEHRNetSDK.Converter
{
    public class PractitionerPullResponseContentConverter : JsonConverter<PractitionerPullResponseContent>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(PractitionerPullResponseContent).IsAssignableFrom(typeToConvert);
        }

        public override PractitionerPullResponseContent?
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
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(PractitionerPullSingleResponseContent),
                    options) as PractitionerPullSingleResponseContent;
            if (jsonObject.TryGetProperty("results", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(PractitionerPullBundleResponseContent),
                    options) as PractitionerPullBundleResponseContent;

            throw new NotSupportedException("JsonObject can not be deserialized to PractitionerPullResponseContent");
        }

        public override void Write(Utf8JsonWriter writer, PractitionerPullResponseContent value,
            JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}