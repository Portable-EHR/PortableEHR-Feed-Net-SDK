// Copyright © Portable EHR inc, 2021
// https://portableehr.com/

using System;
using System.Text.Json.Serialization;

namespace PortableEHRNetSDK.Model.Client
{
    public class JurisdictionIdIssuer
    {
        [JsonPropertyName("issuerKind")] public IdIssuerKindEnum issuerKind { get; set; }

        [JsonPropertyName("country")] public CountryEnum country { get; set; }

        [JsonPropertyName("state")] public string state { get; set; }

        [JsonPropertyName("issuer")] public string issuer { get; set; }

        [JsonPropertyName("issuerAlias")] public string issuerAlias { get; set; }

        [JsonPropertyName("description")] public string description { get; set; }

        [JsonPropertyName("guid")] public Guid guid { get; set; }

        [JsonPropertyName("isTechnical")] public bool isTechnical { get; set; }

        [JsonPropertyName("officialWWWurl")] public string officialWWWurl { get; set; }
    }
}