// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Network.Client.Request.Privatemessage;

namespace PortableEHRNetSDK.Converter
{
    public class PrivateMessageNotificationParametersConverter : JsonConverter<PrivateMessageNotificationParameters>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(PrivateMessageNotificationParameters).IsAssignableFrom(typeToConvert);
        }

        public override PrivateMessageNotificationParameters?
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
            if (jsonObject.TryGetProperty("physicianId", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart,
                        typeof(PrivateMessageNotificationParametersWithPhysicianId), options) as
                    PrivateMessageNotificationParametersWithPhysicianId;
            if (jsonObject.TryGetProperty("author", out outElement))
                return JsonSerializer.Deserialize(ref readerAtStart,
                        typeof(PrivateMessageNotificationParametersWithAuthor), options) as
                    PrivateMessageNotificationParametersWithAuthor;

            throw new NotSupportedException(
                "JsonObject can not be deserialized to PrivateMessageNotificationParameters");
        }

        public override void Write(Utf8JsonWriter writer, PrivateMessageNotificationParameters value,
            JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}