// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Network.Server.Request.Patient
{
    public class PatientPullBundleParameters : PatientPullParameters
    {
        [JsonPropertyName("since")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime since { get; set; }

        [JsonPropertyName("offset")] public int offset { get; set; }

        [JsonPropertyName("maxItems")] public int maxItems { get; set; }
    }
}