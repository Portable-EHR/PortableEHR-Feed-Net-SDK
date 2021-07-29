// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Model.Server;

namespace PortableEHRNetSDK.Converter
{
    public class AppointmentDispositionEnumConverter : JsonConverter<AppointmentDispositionEnum>
    {
        public override AppointmentDispositionEnum Read(ref Utf8JsonReader reader, Type typeToConvert,
            JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return AppointmentDispositionEnum.GetFromValue(value);
        }

        public override void Write(Utf8JsonWriter writer, AppointmentDispositionEnum myEnum,
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(myEnum.Value);
        }
    }
}