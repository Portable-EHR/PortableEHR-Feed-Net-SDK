// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;
using PortableEHRNetSDK.Converter;

namespace PortableEHRNetSDK.Model.Server
{
    public class PatientLegitId
    {
        [JsonPropertyName("feedItemId")] public Guid feedItemId { get; set; }

        [JsonPropertyName("backendItemId")] public Guid backendItemId { get; set; }

        [JsonPropertyName("issuerKind")] public IdIssuerKindEnum issuerKind { get; set; }

        [JsonPropertyName("issuerAlias")] public string issuerAlias { get; set; }

        [JsonPropertyName("number")] public string number { get; set; }

        [JsonPropertyName("version")] public string version { get; set; }

        [JsonPropertyName("expiresOn")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTime expiresOn { get; set; }
    }
}