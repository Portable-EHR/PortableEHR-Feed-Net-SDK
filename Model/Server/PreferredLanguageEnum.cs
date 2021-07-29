// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    [JsonConverter(typeof(PreferredLanguageEnumConverter))]
    public class PreferredLanguageEnum
    {
        private PreferredLanguageEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static PreferredLanguageEnum EN => new("en");
        public static PreferredLanguageEnum FR => new("fr");

        public static PreferredLanguageEnum GetFromValue(string Value)
        {
            if (EN.Value == Value) return EN;
            if (FR.Value == Value) return FR;

            throw new Exception($"Unknown language {Value}");
        }
    }
}