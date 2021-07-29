// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    [JsonConverter(typeof(LicenseIssuerKindEnumConverter))]
    public class LicenseIssuerKindEnum
    {
        private LicenseIssuerKindEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static LicenseIssuerKindEnum PRACTICE_LICENSE => new("practiceLicense");

        public static LicenseIssuerKindEnum GetFromValue(string Value)
        {
            if (PRACTICE_LICENSE.Value == Value) return PRACTICE_LICENSE;

            throw new Exception("Unknown country value");
        }
    }
}