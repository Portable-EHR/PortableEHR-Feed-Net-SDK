// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Network.Server.Response.Patient;

namespace PortableEHRNetSDK.Converter
{
    public class PatientPullResponseContentConverter : JsonConverter<PatientPullResponseContent>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(PatientPullResponseContent).IsAssignableFrom(typeToConvert);
        }

        public override PatientPullResponseContent?
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
            if (jsonObject.TryGetProperty("results", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(PatientPullBundleResponseContent), options)
                    as PatientPullBundleResponseContent;
            if (jsonObject.TryGetProperty("feedItemId", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(PatientPullSingleResponseContent), options)
                    as PatientPullSingleResponseContent;


            throw new NotSupportedException("JsonObject can not be deserialized to PatientPullResponseContent");
        }

        public override void Write(Utf8JsonWriter writer, PatientPullResponseContent value,
            JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}