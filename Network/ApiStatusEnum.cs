// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Network
{
    [JsonConverter(typeof(ApiStatusEnumConverter))]
    public class ApiStatusEnum
    {
        private ApiStatusEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static ApiStatusEnum OK => new("OK");
        public static ApiStatusEnum INTERNAL => new("INTERNAL");
        public static ApiStatusEnum INVALID_COMMAND => new("INVALID_COMMAND");
        public static ApiStatusEnum INVALID_PARAMETERS => new("INVALID_PARAMETERS");
        public static ApiStatusEnum MALFORMED => new("MALFORMED");
        public static ApiStatusEnum BACKEND => new("BACKEND");
        public static ApiStatusEnum AUTH => new("AUTH");
        public static ApiStatusEnum ACCESS => new("ACCESS");
        public static ApiStatusEnum NOT_FOUND => new("NOT_FOUND");
        public static ApiStatusEnum UNREACHABLE => new("UNREACHABLE");
        public static ApiStatusEnum TRANSPORT => new("TRANSPORT");
        public static ApiStatusEnum FEED => new("FEED");

        public static ApiStatusEnum GetFromValue(string Value)
        {
            if (OK.Value == Value) return OK;
            if (INTERNAL.Value == Value) return INTERNAL;
            if (INVALID_COMMAND.Value == Value) return INVALID_COMMAND;
            if (INVALID_PARAMETERS.Value == Value) return INVALID_PARAMETERS;
            if (MALFORMED.Value == Value) return MALFORMED;
            if (BACKEND.Value == Value) return BACKEND;
            if (AUTH.Value == Value) return AUTH;
            if (ACCESS.Value == Value) return ACCESS;
            if (NOT_FOUND.Value == Value) return NOT_FOUND;
            if (UNREACHABLE.Value == Value) return UNREACHABLE;
            if (TRANSPORT.Value == Value) return TRANSPORT;
            if (FEED.Value == Value) return FEED;

            throw new Exception("Unknown country value");
        }
    }
}