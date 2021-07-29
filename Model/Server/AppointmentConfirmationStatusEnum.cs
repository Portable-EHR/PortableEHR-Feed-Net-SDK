// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    [JsonConverter(typeof(AppointmentConfirmationStatusEnumConverter))]
    public class AppointmentConfirmationStatusEnum
    {
        private AppointmentConfirmationStatusEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static AppointmentConfirmationStatusEnum PENDING => new("pending");
        public static AppointmentConfirmationStatusEnum CONFIRMED => new("confirmed");
        public static AppointmentConfirmationStatusEnum CANCELLED => new("cancelled");

        public static AppointmentConfirmationStatusEnum GetFromValue(string Value)
        {
            if (PENDING.Value == Value) return PENDING;
            if (CONFIRMED.Value == Value) return CONFIRMED;
            if (CANCELLED.Value == Value) return CANCELLED;

            throw new Exception("Unknown country value");
        }
    }
}