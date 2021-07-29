// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    [JsonConverter(typeof(PrivateMessageStatusEnumConverter))]
    public class PrivateMessageStatusEnum
    {
        private PrivateMessageStatusEnum(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public static PrivateMessageStatusEnum RECEIVED => new("received");
        public static PrivateMessageStatusEnum REMINDED => new("reminded");
        public static PrivateMessageStatusEnum NOTIFIED => new("notified");
        public static PrivateMessageStatusEnum SENT => new("sent");
        public static PrivateMessageStatusEnum SEEN => new("seen");
        public static PrivateMessageStatusEnum ACKNOWLEDGED => new("acknowledged");
        public static PrivateMessageStatusEnum FALLBACK => new("fallback");
        public static PrivateMessageStatusEnum FAILED => new("failed");

        public static PrivateMessageStatusEnum GetFromValue(string Value)
        {
            if (RECEIVED.Value == Value) return RECEIVED;
            if (REMINDED.Value == Value) return REMINDED;
            if (NOTIFIED.Value == Value) return NOTIFIED;
            if (SENT.Value == Value) return SENT;
            if (SEEN.Value == Value) return SEEN;
            if (ACKNOWLEDGED.Value == Value) return ACKNOWLEDGED;
            if (FALLBACK.Value == Value) return FALLBACK;
            if (FAILED.Value == Value) return FAILED;

            throw new Exception("Unknown country value");
        }
    }
}