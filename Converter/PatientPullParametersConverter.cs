// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Network.Server.Request.Patient;

namespace PortableEHRNetSDK.Converter
{
    public class PatientPullParametersConverter : JsonConverter<PatientPullParameters>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(PatientPullParameters).IsAssignableFrom(typeToConvert);
        }

        public override PatientPullParameters?
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
            if (jsonObject.TryGetProperty("since", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(PatientPullSingleParameters), options) as
                    PatientPullSingleParameters;
            if (jsonObject.TryGetProperty("feedItemId", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(PatientPullBundleParameters), options) as
                    PatientPullBundleParameters;


            throw new NotSupportedException("JsonObject can not be deserialized to PatientPullResponseContent");
        }

        public override void Write(Utf8JsonWriter writer, PatientPullParameters value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}