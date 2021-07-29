// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    public class Patient
    {
        [JsonPropertyName("feedAlias")] public string feedAlias { get; set; }

        [JsonPropertyName("feedItemId")] public Guid feedItemId { get; set; }

        [JsonPropertyName("backendItemId")] public Guid backendItemId { get; set; }

        [JsonPropertyName("lastUpdated")]
        [JsonConverter(typeof(DateTimeFormatConverter))]
        public DateTime lastUpdated { get; set; }

        [JsonPropertyName("feedItemVersion")] public int feedItemVersion { get; set; }

        [JsonPropertyName("chartNumber")] public string chartNumber { get; set; }

        [JsonPropertyName("primaryFeedPractitionerId")]
        public string primaryFeedPractitionerId { get; set; }

        [JsonPropertyName("demographics")] public Demographics demographics { get; set; }

        [JsonPropertyName("identifiedBy")] public List<PatientLegitId> identifiedBy { get; set; }

        [JsonPropertyName("locatedWith")] public PatientLocatedWith locatedWith { get; set; }
    }
}