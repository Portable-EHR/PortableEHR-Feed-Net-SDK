// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    public class Practitioner
    {
        [JsonPropertyName("feedAlias")] public string feedAlias { get; set; }

        [JsonPropertyName("feedItemId")] public Guid feedItemId { get; set; }

        [JsonPropertyName("backendItemId")] public Guid backendItemId { get; set; }

        [JsonPropertyName("lastUpdated")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime lastUpdated { get; set; }

        [JsonPropertyName("feedItemVersion")] public int feedItemVersion { get; set; }

        [JsonPropertyName("id")] public Guid id { get; set; }

        [JsonPropertyName("firstName")] public string firstName { get; set; }

        [JsonPropertyName("lastName")] public string lastName { get; set; }

        [JsonPropertyName("middleName")] public string middleName { get; set; }

        [JsonPropertyName("practices")] public List<Practice> practices { get; set; }
    }
}