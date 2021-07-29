// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    [JsonConverter(typeof(GenderEnumConverter))]
    public class GenderEnum
    {
        private GenderEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static GenderEnum F => new("F");
        public static GenderEnum M => new("M");
        public static GenderEnum N => new("N");

        public static GenderEnum GetFromValue(string Value)
        {
            if (F.Value == Value) return F;
            if (M.Value == Value) return M;
            if (N.Value == Value) return N;

            throw new Exception("Unknown country value");
        }
    }
}