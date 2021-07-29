// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    [JsonConverter(typeof(AppointmentLocationEnumConverter))]
    public class AppointmentLocationEnum
    {
        private AppointmentLocationEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static AppointmentLocationEnum CLINIC => new("clinic");
        public static AppointmentLocationEnum HOME => new("home");
        public static AppointmentLocationEnum VIDEO => new("video");
        public static AppointmentLocationEnum TELEPHONE => new("telephone");

        public static AppointmentLocationEnum GetFromValue(string Value)
        {
            if (CLINIC.Value == Value) return CLINIC;
            if (HOME.Value == Value) return HOME;
            if (VIDEO.Value == Value) return VIDEO;
            if (TELEPHONE.Value == Value) return TELEPHONE;

            throw new Exception("Unknown country value");
        }
    }
}