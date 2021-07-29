// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    [JsonConverter(typeof(AppointmentDispositionEnumConverter))]
    public class AppointmentDispositionEnum
    {
        private AppointmentDispositionEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static AppointmentDispositionEnum PATIENTCONFIRMED => new("patientConfirmed");
        public static AppointmentDispositionEnum PATIENTUNCONFIRMED => new("patientUnconfirmed");
        public static AppointmentDispositionEnum PATIENTCANCELLED => new("patientCancelled");

        public static AppointmentDispositionEnum GetFromValue(string Value)
        {
            if (PATIENTCONFIRMED.Value == Value) return PATIENTCONFIRMED;
            if (PATIENTUNCONFIRMED.Value == Value) return PATIENTUNCONFIRMED;
            if (PATIENTCANCELLED.Value == Value) return PATIENTCANCELLED;

            throw new Exception("Unknown country value");
        }
    }
}