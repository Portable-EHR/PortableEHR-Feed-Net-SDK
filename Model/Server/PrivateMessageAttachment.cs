// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    public class PrivateMessageAttachment
    {
        [JsonPropertyName("name")] public string name { get; set; }

        [JsonPropertyName("date")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTime date { get; set; }

        [JsonPropertyName("mimeType")] public string mimeType { get; set; }

        [JsonPropertyName("ext")] public string ext { get; set; }

        [JsonPropertyName("docAsB64")] public string docAsB64 { get; set; }
    }
}