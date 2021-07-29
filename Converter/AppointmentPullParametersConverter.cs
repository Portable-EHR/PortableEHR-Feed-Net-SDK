// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Network.Server.Request.Appointment;

namespace PortableEHRNetSDK.Converter
{
    public class AppointmentPullParametersConverter : JsonConverter<AppointmentPullParameters>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(AppointmentPullParameters).IsAssignableFrom(typeToConvert);
        }

        public override AppointmentPullParameters?
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
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(AppointmentPullSingleParameters), options)
                    as AppointmentPullSingleParameters;
            if (jsonObject.TryGetProperty("since", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart, typeof(AppointmentPullBundleParameters), options)
                    as AppointmentPullBundleParameters;

            throw new NotSupportedException("JsonObject can not be deserialized to AppointmentPullParameters");
        }

        public override void Write(Utf8JsonWriter writer, AppointmentPullParameters value,
            JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}