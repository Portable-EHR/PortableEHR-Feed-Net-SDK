// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model
{
    [JsonConverter(typeof(IdIssuerKindEnumConverter))]
    public class IdIssuerKindEnum
    {
        private IdIssuerKindEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static IdIssuerKindEnum HEALTHCARE => new("healthCare");
        public static IdIssuerKindEnum SOCIAL_SECURITY => new("socialSecurity");
        public static IdIssuerKindEnum PASSPORT => new("passport");
        public static IdIssuerKindEnum DRIVER_LICENSE => new("driverLicense");
        public static IdIssuerKindEnum PRACTICE_LICENSE => new("practiceLicense");
        public static IdIssuerKindEnum STATE_ID => new("stateID");
        public static IdIssuerKindEnum OTHER => new("other");

        public static IdIssuerKindEnum GetFromValue(string Value)
        {
            if (HEALTHCARE.Value == Value) return HEALTHCARE;
            if (SOCIAL_SECURITY.Value == Value) return SOCIAL_SECURITY;
            if (PASSPORT.Value == Value) return PASSPORT;
            if (DRIVER_LICENSE.Value == Value) return DRIVER_LICENSE;
            if (PRACTICE_LICENSE.Value == Value) return PRACTICE_LICENSE;
            if (STATE_ID.Value == Value) return STATE_ID;
            if (OTHER.Value == Value) return OTHER;

            throw new Exception("Unknown country value");
        }
    }
}